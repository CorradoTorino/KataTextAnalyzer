using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextSortModule.UnitTests
{
    [TestClass]
    public class TextSorterTests
    {
        [TestMethod]
        public void SortAlphabetically_SetOfCharactersSeparatedBySpace()
        {
            // Arrange
            var sut = new TextSorter();
            const string text = "a b c d e f g";

            // Act
            var result = sut.Sort(text, SortOption.Alphabetically);

            // Assert
            var expected = new List<string>
            {
                "a",
                "b",
                "c",
                "d",
                "e",
                "f",
                "g"
            };
            expected.Should().BeEquivalentTo(result);
        }

        [TestMethod]
        public void SortAlphabetically_SentenceWithSpace()
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

        [TestMethod]
        public void SortAlphabetically_SetOfCharactersWithDot()
        {
            // Arrange
            var sut = new TextSorter();
            const string text = "d e. A";

            // Act
            var result = sut.Sort(text, SortOption.Alphabetically);
            
            // Assert
            var expected = new List<string>
            {
                "A",
                "d",
                "e"
            };

            expected.Should().BeEquivalentTo(result);
        }

        [TestMethod]
        public void SortAlphabetically_SetOfWordsWithSingleQuote()
        {
            // Arrange
            var sut = new TextSorter();
            const string text = "A sentence' with an hyphen";

            // Act
            var result = sut.Sort(text, SortOption.Alphabetically);

            // Assert
            var expected = new List<string>
            {
                "A",
                "an",
                "hyphen",
                "sentence",
                "with"
            };
            
            expected.Should().BeEquivalentTo(result);
        }

        [TestMethod]
        public void SortAlphabetically_RemoveAllPunctuationsFromTheEnd()
        {
            // Arrange
            var sut = new TextSorter();
            const string text = "a! b\" c# d$ e% f& g' h( i) l* m+ n, o- p. q/ r: s; t? u@ v[ w\\ x] y^ z_ aa` bb{ cc| dd} ee~ ";

            // Act
            var result = sut.Sort(text, SortOption.Alphabetically);

            // Assert
            var expected = new List<string>
            {
                "a", "aa", "b", "bb", "c", "cc", "d", "dd", "e", "ee", "f", "g", "h", "i", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };

            expected.Should().BeEquivalentTo(result);
        }
    }
}
