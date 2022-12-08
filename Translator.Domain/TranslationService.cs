using Translator.Adapters.OpenAis;
using Translator.Domain.Interfaces;

namespace Translator.Domain
{
    public class TranslationService : ITranslationService
    {
        private DavinciAdapter _davinciAdapter;

        public TranslationService(DavinciAdapter davinciAdapter)
        {
            _davinciAdapter = davinciAdapter;

        }

        public async Task<string> GetTranslation(TranslationLanguage from, TranslationLanguage to, string text)
        {
            return await _davinciAdapter.GetTranslation(from.ToString(), to.ToString(), text);
        }
    }
}
