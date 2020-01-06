using System;
using Taknet.Textc.Core.Types;

namespace Taknet.Textc.Core.Csdl
{
    public class ActivatorTokenTypeFactory : ITokenTypeFactory
    {
        public ITokenType Create(Type tokenType, string name, bool isContextual, bool isOptional,
            bool invertParsing)
        {
            return
                (ITokenType)
                    Activator.CreateInstance(tokenType, name, isContextual, isOptional, invertParsing);
        }
    }
}