﻿using Taknet.Textc.Core.Metadata;

namespace Taknet.Textc.Core.Types
{
    [TokenType(ShortName = "RegexWord")]
    public class RegexWordTokenType : RegexTokenTypeBase<string>
    {
        public RegexWordTokenType(string name, bool isContextual, bool isOptional, bool invertParsing)
            : base(name, isContextual, isOptional, invertParsing)
        {
        }

        public override bool TryParse(string token, out string value)
        {
            value = token;
            return !string.IsNullOrEmpty(token);
        }
    }
}