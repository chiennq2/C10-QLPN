using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using C10.MasterData.Configuration;
using C10.MasterData.EntityFrameworkCore;
using C10.MasterData.Migrator.DependencyInjection;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;

namespace C10.MasterData.Migrator;

[DependsOn(typeof(MasterDataEntityFrameworkModule))]
public class MasterDataMigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public MasterDataMigratorModule(MasterDataEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(MasterDataMigratorModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            MasterDataConsts.ConnectionStringName
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
        IocManager.RegisterAssemblyByConvention(typeof(MasterDataMigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}
