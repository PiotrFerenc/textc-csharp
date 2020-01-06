using System.Threading;
using System.Threading.Tasks;

namespace Taknet.Textc.Core.PreProcessors
{
    /// <summary>
    /// Converts the input text to lower case.
    /// </summary>
    /// <seealso cref="ITextPreprocessor" />
    public class ToLowerCasePreprocessor : ITextPreprocessor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToLowerCasePreprocessor"/> class.
        /// </summary>
        public ToLowerCasePreprocessor()
            : this(0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToLowerCasePreprocessor"/> class.
        /// </summary>
        /// <param name="priority">The priority.</param>
        public ToLowerCasePreprocessor(int priority)
        {
            Priority = priority;
        }

        public Task<string> ProcessTextAsync(string text, IRequestContext context, CancellationToken cancellationToken)
        {
            return Task.FromResult(text.ToLowerInvariant());
        }

        public int Priority { get; }
    }
}