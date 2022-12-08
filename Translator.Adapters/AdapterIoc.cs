using Microsoft.Extensions.DependencyInjection;
using Translator.Adapters.OpenAis;

namespace Translator.Adapters
{
    public static class AdapterIoc
    {
        public static void RegisterAdapters(this IServiceCollection services)
        {
            services.AddTransient<DavinciAdapter>();
        }
    }
}
