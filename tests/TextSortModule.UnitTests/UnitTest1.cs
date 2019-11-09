using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextSortModule.UnitTests
{
    [TestClass]
    public class TextSorterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var sut = new TextSorter();
            const string text = "This is the text to be sorted";
            
            // Act
            var result = sut.Sort(text, SortOption.Alphabetically);

            // Assert
            var expected = new List<string>
            {
                "be",
                "is",
                "sorted",
                "text",
                "the",
                "This",
                "to"
            };
            expected.Should().BeEquivalentTo(result);
        }
    }
}
