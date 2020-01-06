﻿using System;

namespace Taknet.Textc.Core
{
    /// <summary>
    /// Stores information of an extracted expression from the user input that was parsed with a syntax.
    /// </summary>
    public sealed class Expression
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Expression" /> class.
        /// </summary>
        public Expression(Token[] tokens, Syntax syntax, IRequestContext context, string remainingText)
        {
            Tokens = tokens ?? throw new ArgumentNullException(nameof(tokens));            
            Syntax = syntax ?? throw new ArgumentNullException(nameof(syntax));
            Context = context ?? throw new ArgumentNullException(nameof(context));
            RemainingText = remainingText;
        }

        /// <summary>
        /// Gets the tokens that compose the expression.
        /// </summary>
        public Token[] Tokens { get; }

        /// <summary>
        /// Gets the syntax that originated the expression.
        /// </summary>
        public Syntax Syntax { get; }

        /// <summary>
        /// Gets the associated request context.
        /// </summary>
        public IRequestContext Context { get; }

        /// <summary>
        /// Gets the remaining input text that was not processed.
        /// In case of perfect match syntaxes, this value is null.
        /// </summary>
        public string RemainingText { get; }
    }
}