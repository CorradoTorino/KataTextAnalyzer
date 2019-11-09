using System;
using System.Collections.Generic;
using System.Linq;

namespace TextSortModule.SortStrategies
{
    internal class SortStrategyBySentenceLength : ISortStrategy
    {
        public IEnumerable<string> Sort(string text)
        {
            return text
                .Split(new string[] { ". " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(c => c.TrimEnd(new[] { '.' }))
                .OrderBy(x => x.Length)
                .ToList();
        }
    }
}