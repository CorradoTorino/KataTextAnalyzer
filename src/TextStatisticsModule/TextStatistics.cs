namespace TextStatisticsModule
{
    internal class TextStatistics: ITextStatistics
    {
        public int Hyphens { get; internal set; }
        public int Words { get; internal set; }
        public int Spaces { get; internal set; }
    }
}