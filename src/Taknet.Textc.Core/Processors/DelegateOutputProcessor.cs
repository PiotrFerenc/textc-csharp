using System;
using System.Threading;
using System.Threading.Tasks;

namespace Taknet.Textc.Core.Processors
{
    public sealed class DelegateOutputProcessor<T> : OutputProcessorBase<T>
    {
        private readonly Func<T, IRequestContext, CancellationToken, Task> _func;

        public DelegateOutputProcessor(Action<T, IRequestContext> action)
            : this((o, c) => { action(o, c); return Task.FromResult(0); })
        {
            
        }

        public DelegateOutputProcessor(Func<T, IRequestContext, Task> func)
            : this((o, c, t) => { t.ThrowIfCancellationRequested(); return func(o, c); })
        {
            
        }

        public DelegateOutputProcessor(Func<T, IRequestContext, CancellationToken, Task> func)
        {
            _func = func ?? throw new ArgumentNullException(nameof(func));
        }

        public override Task ProcessOutputAsync(T output, IRequestContext context, CancellationToken cancellationToken)
        {
            return _func(output, context, cancellationToken);
        }
    }
}
