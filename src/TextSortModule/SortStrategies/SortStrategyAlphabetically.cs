using System;
using System.Collections.Generic;
using System.Linq;

namespace TextSortModule.SortStrategies
{
    internal class SortStrategyAlphabetically : ISortStrategy
    {
        public IEnumerable<string> Sort(string text)
        {
            var result = text
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(c => c.TrimEnd(TextSorter.PunctuationsList)).ToList();

            result.Sort();
            return result;
        }
    }
}