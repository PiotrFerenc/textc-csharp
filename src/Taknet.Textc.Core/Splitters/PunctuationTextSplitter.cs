using System;
using System.Collections.Generic;

namespace Taknet.Textc.Core.Splitters
{
    public class PunctuationTextSplitter : ITextSplitter
    {
        public static string[] SplitMarkers = new[]
        {
            ",",
            ";",
            ".",
            "!",
            ":",
            "?"
        };

        public IEnumerable<string> Split(string inputText) 
            => inputText?.Split(SplitMarkers, StringSplitOptions.RemoveEmptyEntries);
    }
}
