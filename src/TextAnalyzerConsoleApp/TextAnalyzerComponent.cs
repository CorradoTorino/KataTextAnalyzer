using System;
using System.Collections.Generic;
using TextSortFileService;
using TextSortModule;
using TextStatisticsFileService;
using TextStatisticsModule;

namespace TextAnalyzerConsoleApp
{
    public class TextAnalyzerComponent : ITextSorterFileService, ITextStatisticianFileService
    {
        readonly ITextSorterFileService textSort = new TextSorterFileService();
        readonly ITextStatisticianFileService statistician = new TextStatisticianFileService();

        public IEnumerable<string> Sort(Uri filePath, SortOption option)
        {
            return this.textSort.Sort(filePath, option);
        }

        public ITextStatistics GetStatistics(Uri textToBeAnalyzed)
        {
            return statistician.GetStatistics(textToBeAnalyzed);
        }
    }
}
