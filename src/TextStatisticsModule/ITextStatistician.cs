namespace TextStatisticsModule
{
    public interface ITextStatistician
    {
        ITextStatistics GetStatistics(string text);
    }
}
