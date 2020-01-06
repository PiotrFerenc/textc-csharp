using System;
using Taknet.Textc.Core.Types;

namespace Taknet.Textc.Core.Csdl
{
    /// <summary>
    /// Defines a factory for token types.
    /// </summary>
    public interface ITokenTypeFactory
    {
        ITokenType Create(Type tokenType, string name, bool isContextual, bool isOptional, bool invertParsing);
    }
}