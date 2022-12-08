using OpenAI;

namespace Translator.Adapters.OpenAis
{
    public class DavinciAdapter
    {
        static readonly string epicApiHardcodedKey = "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";
        private readonly OpenAIClient _api;
        public DavinciAdapter()
        {
            _api = new OpenAIClient(new OpenAIAuthentication(epicApiHardcodedKey), new Engine("text-davinci-003"));
        }

        public async Task<string> GetTranslation(string from, string to, string text)
        {
            string prompt = PreparePromt(from, to, text);
            var compl = (await CallDavinci(prompt));
            return compl.Completions.FirstOrDefault();
        }

        private async Task<CompletionResult> CallDavinci(string prompt)
        {
            return await _api.CompletionEndpoint.CreateCompletionAsync(prompt: prompt, top_p: 1, temperature: 0.3, frequencyPenalty: 0, presencePenalty: 0, numOutputs: 1, max_tokens: 300);
        }

        private string PreparePromt(string from, string to, string text)
        {
            return $"Translate this from {from} to {to}: {text}.";
        }
    }
}
