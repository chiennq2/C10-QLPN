import { createHash } from "crypto";
import { spawn } from "child_process";
import http from "http";
import https from "https";

const swaggerUrl =
  process.env.NSWAG_URL ?? "http://localhost:44310/swagger/v1/swagger.json";
const pollMs = Number(process.env.NSWAG_POLL_MS ?? 5000);
const allowInsecure = process.env.NSWAG_ALLOW_INSECURE === "1";

let lastHash = "";
let running = false;

function fetchSwagger() {
  const url = new URL(swaggerUrl);
  const client = url.protocol === "https:" ? https : http;

  const options = {
    method: "GET",
    hostname: url.hostname,
    port: url.port || (url.protocol === "https:" ? 443 : 80),
    path: `${url.pathname}${url.search}`,
    headers: { accept: "application/json" },
    ...(url.protocol === "https:" ? { rejectUnauthorized: !allowInsecure } : {}),
  };

  return new Promise((resolve, reject) => {
    const req = client.request(options, (res) => {
      if (res.statusCode && res.statusCode >= 400) {
        res.resume();
        reject(new Error(`HTTP ${res.statusCode}`));
        return;
      }

      res.setEncoding("utf8");
      let data = "";
      res.on("data", (chunk) => {
        data += chunk;
      });
      res.on("end", () => resolve(data));
    });

    req.on("error", reject);
    req.end();
  });
}

function runNswag() {
  return new Promise((resolve, reject) => {
    const cmd = process.platform === "win32" ? "npx.cmd" : "npx";
    const child = spawn(cmd, ["nswag", "run", "nswag/service.config.nswag"], {
      stdio: "inherit",
    });

    child.on("exit", (code) => {
      if (code === 0) {
        resolve();
      } else {
        reject(new Error(`nswag exited with code ${code}`));
      }
    });
  });
}

async function checkOnce() {
  if (running) {
    return;
  }

  try {
    const swaggerText = await fetchSwagger();
    const hash = createHash("sha256").update(swaggerText).digest("hex");

    if (hash !== lastHash) {
      lastHash = hash;
      running = true;
      console.log("[nswag-watch] Swagger changed, generating...");
      await runNswag();
      console.log("[nswag-watch] Done.");
    }
  } catch (error) {
    const message = error instanceof Error ? error.message : String(error);
    console.log(`[nswag-watch] ${message}`);
  } finally {
    running = false;
  }
}

console.log(`[nswag-watch] Watching ${swaggerUrl} every ${pollMs}ms`);
if (allowInsecure) {
  console.log("[nswag-watch] TLS verification disabled for swagger fetch");
}

setInterval(checkOnce, pollMs);
checkOnce();
