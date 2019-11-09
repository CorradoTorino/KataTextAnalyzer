using System.Collections.Generic;
using TextSortModule;

namespace TextSortFileService
{
    public interface ITextSorterFileService
    {
        /// <summary>
        /// Sort the text found in the given file.
        /// </summary>
        /// <param name="filePath">The text to be analyzed</param>
        /// <param name="option">The Sort Option</param>
        /// <returns>The result of the sorting algorithm.</returns>
        IEnumerable<string> Sort(string filePath, SortOption option);
    }
}
