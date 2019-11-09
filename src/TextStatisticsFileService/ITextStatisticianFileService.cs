using System;
using TextStatisticsModule;

namespace TextStatisticsFileService
{
    public interface ITextStatisticianFileService
    {
        /// <summary>
        /// Get the statistic of the stored in the uri
        /// </summary>
        /// <param name="textToBeAnalyzed">The uri if the text to be analyzed</param>
        /// <returns>The Statistics.</returns>
        ITextStatistics GetStatistics(Uri textToBeAnalyzed);
    }
}
