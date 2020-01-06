using Taknet.Textc.Core.Metadata;

namespace Taknet.Textc.Core.Types
{
    [TokenType(ShortName = "Long")]
    public class LongTokenType : ValueTokenTypeBase<long>
    {
        public LongTokenType(string name, bool isContextual, bool isOptional, bool invertParsing)
            : base(name, isContextual, isOptional, invertParsing)
        {
        }
    }
}