using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace C10.MasterData;

[DependsOn(
    typeof(MasterDataCoreModule),
    typeof(MasterDataDomainModule),
    typeof(AbpAutoMapperModule))]
public class MasterDataApplicationModule : AbpModule
{
    //public override void PreInitialize()
    //{
    //   // Configuration.Authorization.Providers.Add<MasterDataAuthorizationProvider>();
    //}

    public override void Initialize()
    {
        var thisAssembly = typeof(MasterDataApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
