using System;
using System.Collections.Generic;
using TextSortModule.SortStrategies;

namespace TextSortModule
{
    /// <inheritdoc/>
    public class TextSorter : ITextSorter
    {
        internal static readonly char[] PunctuationsList = new []{ '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '?', '@', '[', '\\', ']', '^', '_', '`', '{', '|', '}', '~'};

        /// <inheritdoc/>
        public IEnumerable<string> Sort(string text, SortOption option)
        {
            ISortStrategy sortStrategy;
            
            switch (option)
            {
                case SortOption.Alphabetically:
                    sortStrategy = new SortStrategyAlphabetically();
                    break;
                case SortOption.ByWordLength:
                    sortStrategy = new SortStrategyByWordLength();
                    break;
                case SortOption.BySentenceLength:
                    sortStrategy = new SortStrategyBySentenceLength();
                    break;
                default:
                    throw new NotSupportedException();
            }

            return sortStrategy.Sort(text);
        }
    }
}