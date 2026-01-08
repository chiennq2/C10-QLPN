using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace C10.MasterData.Web.Tests;

[DependsOn(
    typeof(MasterDataWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class MasterDataWebTestModule : AbpModule
{
    public MasterDataWebTestModule(MasterDataEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(MasterDataWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(MasterDataWebMvcModule).Assembly);
    }
}