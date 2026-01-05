using C10.Configuration;
using C10.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace C10.EntityFrameworkCore;

/* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
public class C10DbContextFactory : IDesignTimeDbContextFactory<C10DbContext>
{
    public C10DbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<C10DbContext>();

        /*
         You can provide an environmentName parameter to the AppConfigurations.Get method. 
         In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
         Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
         https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
         */
        var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

        C10DbContextConfigurer.Configure(builder, configuration.GetConnectionString(C10Consts.ConnectionStringName));

        return new C10DbContext(builder.Options);
    }
}
