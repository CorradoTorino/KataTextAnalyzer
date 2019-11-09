using System.Collections.Generic;

namespace TextSortModule
{
    public interface ITextSorter
    {
        IEnumerable<string> Sort(string text, SortOption option);
    }
}
