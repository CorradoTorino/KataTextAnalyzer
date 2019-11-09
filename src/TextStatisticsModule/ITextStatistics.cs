namespace TextStatisticsModule
{
    public interface ITextStatistics
    {
        int Hyphens { get; }
        int Words { get; }
        int Spaces { get;  }
    }
}