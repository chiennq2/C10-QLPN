FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/C10.MasterData.Web.Host/C10.MasterData.Web.Host.csproj", "src/C10.MasterData.Web.Host/"]
COPY ["src/C10.MasterData.Web.Core/C10.MasterData.Web.Core.csproj", "src/C10.MasterData.Web.Core/"]
COPY ["src/C10.MasterData.Application/C10.MasterData.Application.csproj", "src/C10.MasterData.Application/"]
COPY ["src/C10.MasterData.Core/C10.MasterData.Core.csproj", "src/C10.MasterData.Core/"]
COPY ["src/C10.MasterData.EntityFrameworkCore/C10.MasterData.EntityFrameworkCore.csproj", "src/C10.MasterData.EntityFrameworkCore/"]
WORKDIR "/src/src/C10.MasterData.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/C10.MasterData.Web.Host", "src/C10.MasterData.Web.Host"]
COPY ["src/C10.MasterData.Web.Core", "src/C10.MasterData.Web.Core"]
COPY ["src/C10.MasterData.Application", "src/C10.MasterData.Application"]
COPY ["src/C10.MasterData.Core", "src/C10.MasterData.Core"]
COPY ["src/C10.MasterData.EntityFrameworkCore", "src/C10.MasterData.EntityFrameworkCore"]
WORKDIR "/src/src/C10.MasterData.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "C10.MasterData.Web.Host.dll"]
