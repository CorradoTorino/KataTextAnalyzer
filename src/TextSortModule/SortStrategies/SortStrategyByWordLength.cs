using System;
using System.Collections.Generic;
using System.Linq;

namespace TextSortModule.SortStrategies
{
    internal class SortStrategyByWordLength : ISortStrategy
    {
        public IEnumerable<string> Sort(string text)
        {
            var result = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            result = result.Select(c => c.TrimEnd(TextSorter.PunctuationsList)).ToList();
            result = result.OrderBy(x => x.Length).ToList();
            return result;
        }
    }
}