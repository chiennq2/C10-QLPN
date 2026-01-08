using Abp.Dependency;
using C10.MasterData.EntityFrameworkCore;
using Castle.MicroKernel.Registration;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace C10.MasterData.Tests.DependencyInjection;

public static class ServiceCollectionRegistrar
{
    public static void Register(IIocManager iocManager)
    {
        var services = new ServiceCollection();

      //  IdentityRegistrar.Register(services);

        services.AddEntityFrameworkInMemoryDatabase();

        var serviceProvider = WindsorRegistrationHelper.CreateServiceProvider(iocManager.IocContainer, services);

        var builder = new DbContextOptionsBuilder<MasterDataDbContext>();
        builder.UseInMemoryDatabase(Guid.NewGuid().ToString()).UseInternalServiceProvider(serviceProvider);

        iocManager.IocContainer.Register(
            Component
                .For<DbContextOptions<MasterDataDbContext>>()
                .Instance(builder.Options)
                .LifestyleSingleton()
        );
    }
}
