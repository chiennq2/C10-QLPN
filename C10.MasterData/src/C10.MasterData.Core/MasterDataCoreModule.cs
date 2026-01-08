using Abp;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Security;
using Abp.Timing;
using C10.MasterData.Configuration;
using C10.MasterData.Localization;
using C10.MasterData.Timing;
using System.Transactions;

namespace C10.MasterData;

[DependsOn(typeof(AbpKernelModule))]
public class MasterDataCoreModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Auditing.IsEnabledForAnonymousUsers = true;

        // Declare entity types
        //Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
       

        MasterDataLocalizationConfigurer.Configure(Configuration.Localization);

        // Enable this line to create a multi-tenant application.
       // Configuration.MultiTenancy.IsEnabled = MasterDataConsts.MultiTenancyEnabled;

        // Configure roles
        //AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);
        Configuration.UnitOfWork.IsolationLevel = IsolationLevel.ReadCommitted;
        Configuration.Settings.Providers.Add<AppSettingProvider>();

       // Configuration.Localization.Languages.Add(new LanguageInfo("fa", "فارسی", "famfamfam-flags ir"));

        Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = MasterDataConsts.DefaultPassPhrase;
        SimpleStringCipher.DefaultPassPhrase = MasterDataConsts.DefaultPassPhrase;
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(MasterDataCoreModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
    }
}
