namespace TextStatisticsModule.UnitTests.TestInfrastructure
{
    internal class TextStatisticsStub : ITextStatistics
    {
        public TextStatisticsStub(int hyphens, int words, int spaces)
        {
            this.Hyphens = hyphens;
            this.Words = words;
            this.Spaces = spaces;
        }

        public int Hyphens { get; internal set; }
        public int Words { get; internal set; }
        public int Spaces { get; internal set; }
    }
}