using System.Collections.Generic;

namespace TextSortModule.SortStrategies
{
    internal interface ISortStrategy
    {
        IEnumerable<string> Sort(string text);
    }
}