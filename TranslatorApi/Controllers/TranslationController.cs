using Microsoft.AspNetCore.Mvc;
using Translator.Domain;
using Translator.Domain.Interfaces;

namespace TranslatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TranslationController : ControllerBase
    {
        private readonly ITranslationService _translationService;

        public TranslationController(ITranslationService translationService)
        {
            _translationService = translationService;
        }
        [HttpGet(Name = "GetTranslation")]
        public async Task<string> Get(TranslationLanguage from, TranslationLanguage to, string text)
        {
            var translation = await _translationService.GetTranslation(from, to, text);
            return translation;
        }
    }
}
