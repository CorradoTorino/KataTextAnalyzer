using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextStatisticsModule.UnitTests.TestInfrastructure;

namespace TextStatisticsModule.UnitTests
{
    [TestClass]
    public class StatisticiansTests
    {
        [TestMethod]
        public void GetStatistics()
        {
            // Arrange
            var sut = new TextStatistician();

            // Act
            var result = sut.GetStatistics(string.Empty);

            // Assert
            var expected = new TextStatisticsStub(0, 0, 0);
            expected.Should().BeEquivalentTo(result);
        }

        [TestMethod]
        public void GetStatistics_FromTextWith2Hyphens3Spaces4Words()
        {
            // Arrange
            var sut = new TextStatistician();
            var text = "Sentence with  - Hyphens - Spaces and some Words";

            // Act
            var result = sut.GetStatistics(text);

            // Assert
            var expected = new TextStatisticsStub(2, 7, 9);
            result.Should().BeEquivalentTo(expected);
        }
    }
}
