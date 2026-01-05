using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using C10.Authorization;

namespace C10;

[DependsOn(
    typeof(C10CoreModule),
    typeof(AbpAutoMapperModule))]
public class C10ApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<C10AuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(C10ApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
