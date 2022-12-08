using System.Transactions;

namespace Translator.Domain.Interfaces
{
    public interface ITranslationService
    {
        Task<string> GetTranslation(TranslationLanguage from, TranslationLanguage to, string text);
    }
}
