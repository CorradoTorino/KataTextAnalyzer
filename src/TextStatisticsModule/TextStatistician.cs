using System;

namespace TextStatisticsModule
{
    public class TextStatistician: ITextStatistician
    {
        public ITextStatistics GetStatistics(string text)
        {
            return new TextStatistics()
            {
                Hyphens = 0,
                Spaces = 0,
                Words = 0,
            };
        }
    }
}