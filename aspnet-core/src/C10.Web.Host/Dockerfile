FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/C10.Web.Host/C10.Web.Host.csproj", "src/C10.Web.Host/"]
COPY ["src/C10.Web.Core/C10.Web.Core.csproj", "src/C10.Web.Core/"]
COPY ["src/C10.Application/C10.Application.csproj", "src/C10.Application/"]
COPY ["src/C10.Core/C10.Core.csproj", "src/C10.Core/"]
COPY ["src/C10.EntityFrameworkCore/C10.EntityFrameworkCore.csproj", "src/C10.EntityFrameworkCore/"]
WORKDIR "/src/src/C10.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/C10.Web.Host", "src/C10.Web.Host"]
COPY ["src/C10.Web.Core", "src/C10.Web.Core"]
COPY ["src/C10.Application", "src/C10.Application"]
COPY ["src/C10.Core", "src/C10.Core"]
COPY ["src/C10.EntityFrameworkCore", "src/C10.EntityFrameworkCore"]
WORKDIR "/src/src/C10.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "C10.Web.Host.dll"]
