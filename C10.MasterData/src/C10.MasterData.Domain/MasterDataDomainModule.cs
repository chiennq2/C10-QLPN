using Abp.Modules;
using Abp.Reflection.Extensions;

namespace C10.MasterData
{
    [DependsOn(typeof(MasterDataCoreModule))]
    public class MasterDataDomainModule : AbpModule
    {
        public override void Initialize()
        {
            var thisAssembly = typeof(MasterDataDomainModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);
        }
    }
}
