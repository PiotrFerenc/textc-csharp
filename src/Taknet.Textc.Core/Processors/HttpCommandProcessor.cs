using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Taknet.Textc.Core.Processors
{
    public class HttpCommandProcessor : ICommandProcessor
    {
        private readonly string _uriTemplate;
        private readonly string _method;
        private readonly IDictionary<string, string> _headers;

        public HttpCommandProcessor(string uriTemplate, string method, string bodyTemplate = null,
            IDictionary<string, string> headers = null, IOutputProcessor outputProcessor = null, params Syntax[] syntaxes)
        {
            if (syntaxes.Length == 0) throw new ArgumentException("Argument is empty collection", nameof(syntaxes));

            _uriTemplate = uriTemplate ?? throw new ArgumentNullException(nameof(uriTemplate));
            _method = method ?? throw new ArgumentNullException(nameof(method));
            _headers = headers;            
            OutputProcessor = outputProcessor;
            Syntaxes = syntaxes;
        }

        public Syntax[] Syntaxes { get; }

        public Task ProcessAsync(Expression expression, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public IOutputProcessor OutputProcessor { get; }
    }
}
