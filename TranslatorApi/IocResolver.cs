using Translator.Adapters;
using Translator.Domain;
using Translator.Domain.Interfaces;

namespace TranslatorApi
{
    public static class IocResolver
    {
        public static void RegisterDomain(this IServiceCollection services)
        {
            services.RegisterAdapters();
            services.AddTransient<ITranslationService, TranslationService>();
        }
    }
}
