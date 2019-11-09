using System;
using System.Collections.Generic;
using TextSortModule;

namespace TextSortFileService
{
    public interface ITextSorterFileService
    {
        /// <summary>
        /// Sort the text found in the given file.
        /// </summary>
        /// <param name="fileUri">The uri of the text to be analyzed</param>
        /// <param name="option">The Sort Option</param>
        /// <returns>The result of the sorting algorithm.</returns>
        IEnumerable<string> Sort(Uri fileUri, SortOption option);
    }
}
