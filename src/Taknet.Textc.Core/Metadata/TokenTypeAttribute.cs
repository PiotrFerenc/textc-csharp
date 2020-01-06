using System;
using Taknet.Textc.Core.Csdl;

namespace Taknet.Textc.Core.Metadata
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TokenTypeAttribute : Attribute
    {
        public TokenTypeAttribute()
        {
            FactoryType = typeof (ActivatorTokenTypeFactory);
        }

        public string ShortName { get; set; }

        public Type FactoryType { get; set; }
    }
}