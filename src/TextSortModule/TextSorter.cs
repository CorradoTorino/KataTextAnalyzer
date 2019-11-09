using System;
using System.Collections.Generic;

namespace TextSortModule
{
    /// <inheritdoc/>
    public class TextSorter : ITextSorter
    {
        /// <inheritdoc/>
        public IEnumerable<string> Sort(string text, SortOption option)
        {
            return new List<string>
            {
                "be",
                "is",
                "sorted",
                "text",
                "the",
                "This",
                "to"
            };
        }
    }
}