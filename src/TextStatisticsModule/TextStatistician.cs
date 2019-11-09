using System;
using System.Linq;

namespace TextStatisticsModule
{
    public class TextStatistician: ITextStatistician
    {
        internal static readonly string[] PunctuationsList = new[] { "!", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", ":", ";", "?", "@", "[", "\\", "]", "^", "_", "`", "{", "|", "}", "~", "\r", "\n" };
        public ITextStatistics GetStatistics(string text)
        {
            var words = text.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var punctuation in PunctuationsList)
            {
                words.RemoveAll(x => x.Equals(punctuation));
            }

            return new TextStatistics
                {
                    Words = words.Count,
                    Hyphens = text.Count(hyphen => hyphen == '-'),
                    Spaces = text.Count(space => space == ' ')
                };
        }
    }
}