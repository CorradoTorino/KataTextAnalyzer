using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextSortModule.UnitTests
{
 public partial class TextSorterTests
    {
        [TestMethod]
        public void SortBySentenceLength()
        {
            // Arrange
            var sut = new TextSorter();
            const string text = "Short sentence. This a longer sentence.";

            // Act
            var result = sut.Sort(text, SortOption.SentenceLength);

            // Assert
            var expected = new List<string>
            {
                "Short sentence",
                "This a longer sentence"
                
            };
            expected.Should().BeEquivalentTo(result);
        }
    }
}
