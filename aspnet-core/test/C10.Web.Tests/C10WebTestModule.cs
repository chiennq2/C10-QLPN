using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using C10.EntityFrameworkCore;
using C10.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace C10.Web.Tests;

[DependsOn(
    typeof(C10WebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class C10WebTestModule : AbpModule
{
    public C10WebTestModule(C10EntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(C10WebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(C10WebMvcModule).Assembly);
    }
}