using Abp.Modules;
using Abp.Reflection.Extensions;
using C10.MasterData.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace C10.MasterData.Web.Host.Startup
{
    [DependsOn(
       typeof(MasterDataWebCoreModule))]
    public class MasterDataWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MasterDataWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MasterDataWebHostModule).GetAssembly());
        }
    }
}
