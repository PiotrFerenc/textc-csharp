using System;

namespace Taknet.Textc.Core.Metadata
{
    [AttributeUsage(AttributeTargets.Property)]
    public class TokenTypePropertyAttribute : Attribute
    {
        public bool IsDefault { get; set; }
    }
}