using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using C10.Configuration;
using C10.EntityFrameworkCore;
using C10.Migrator.DependencyInjection;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;

namespace C10.Migrator;

[DependsOn(typeof(C10EntityFrameworkModule))]
public class C10MigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public C10MigratorModule(C10EntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(C10MigratorModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            C10Consts.ConnectionStringName
        );

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        Configuration.ReplaceService(
            typeof(IEventBus),
            () => IocManager.IocContainer.Register(
                Component.For<IEventBus>().Instance(NullEventBus.Instance)
            )
        );
        Configuration.UnitOfWork.IsTransactional = false;
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(C10MigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}
