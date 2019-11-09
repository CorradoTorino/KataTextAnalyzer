using System;
using System.Collections.Generic;
using System.Linq;

namespace TextSortModule.SortStrategies
{
    internal class SortStrategyBySentenceLength : ISortStrategy
    {
        public IEnumerable<string> Sort(string text)
        {
            var result = text.Split(new string[] { ". " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            result = result.Select(c => c.TrimEnd(new[] { '.' })).ToList();
            result = result.OrderBy(x => x.Length).ToList();
            return result;
        }
    }
}