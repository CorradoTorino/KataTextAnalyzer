using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextSortModule.UnitTests
{
 public partial class TextSorterTests
    {
        [TestMethod]
        public void SortByWordLength()
        {
            // Arrange
            var sut = new TextSorter();
            const string text = "cc b aaa";

            // Act
            var result = sut.Sort(text, SortOption.ByWordLength);

            // Assert
            var expected = new List<string>
            {
                "b",
                "cc",
                "aaa",
            };
            expected.Should().BeEquivalentTo(result);
        }

        [TestMethod]
        public void SortByWorldLengthWhenThereIsPunctuation()
        {
            // Arrange
            var sut = new TextSorter();
            const string text = "cc. b? aaa";

            // Act
            var result = sut.Sort(text, SortOption.ByWordLength);

            // Assert
            var expected = new List<string>
            {
                "b",
                "cc",
                "aaa",
            };
            expected.Should().BeEquivalentTo(result);
        }
    }
}
