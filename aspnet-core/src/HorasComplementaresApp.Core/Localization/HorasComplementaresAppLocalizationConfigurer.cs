using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HorasComplementaresApp.Localization
{
    public static class HorasComplementaresAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(HorasComplementaresAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HorasComplementaresAppLocalizationConfigurer).GetAssembly(),
                        "HorasComplementaresApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
