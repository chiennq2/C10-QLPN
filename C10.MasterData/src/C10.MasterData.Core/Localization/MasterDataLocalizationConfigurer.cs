using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace C10.MasterData.Localization;

public static class MasterDataLocalizationConfigurer
{
    public static void Configure(ILocalizationConfiguration localizationConfiguration)
    {
        localizationConfiguration.Sources.Add(
            new DictionaryBasedLocalizationSource(MasterDataConsts.LocalizationSourceName,
                new XmlEmbeddedFileLocalizationDictionaryProvider(
                    typeof(MasterDataLocalizationConfigurer).GetAssembly(),
                    "C10.MasterData.Localization.SourceFiles"
                )
            )
        );
    }
}
