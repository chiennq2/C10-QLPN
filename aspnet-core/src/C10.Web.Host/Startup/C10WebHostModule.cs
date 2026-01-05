using Abp.Modules;
using Abp.Reflection.Extensions;
using C10.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace C10.Web.Host.Startup
{
    [DependsOn(
       typeof(C10WebCoreModule))]
    public class C10WebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public C10WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(C10WebHostModule).GetAssembly());
        }
    }
}
