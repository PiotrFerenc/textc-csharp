using System.Threading;
using System.Threading.Tasks;

namespace Taknet.Textc.Core.PreProcessors
{
    public class TrimTextPreprocessor : ITextPreprocessor
    {
        public int Priority => 0;

        public Task<string> ProcessTextAsync(string text, IRequestContext context, CancellationToken cancellationToken)
            => Task.FromResult(text.Trim());
    }
}
