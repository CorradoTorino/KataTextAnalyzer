using System;
using System.Collections.Generic;
using System.Linq;

namespace TextSortModule.SortStrategies
{
    internal class SortStrategyByWordLength : ISortStrategy
    {
        public IEnumerable<string> Sort(string text)
        {
            return text
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(c => c.TrimEnd(TextSorter.PunctuationsList))
                .OrderBy(x => x.Length).ToList();
        }
    }
}