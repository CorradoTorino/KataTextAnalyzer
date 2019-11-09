using System;
using System.Collections.Generic;
using System.Linq;

namespace TextSortModule
{
    /// <inheritdoc/>
    public class TextSorter : ITextSorter
    {
        private readonly char[] punctuationsList = new []{ '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '?', '@', '[', '\\', ']', '^', '_', '`', '{', '|', '}', '~'};

        /// <inheritdoc/>
        public IEnumerable<string> Sort(string text, SortOption option)
        {
            var result = text.Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).ToList();

            result.Sort();

            result = result.Select(c => c.TrimEnd(punctuationsList)).ToList();

            return result;
        }
    }
}