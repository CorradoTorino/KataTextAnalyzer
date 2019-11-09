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
    }
}
