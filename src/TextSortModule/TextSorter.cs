using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace TextSortModule
{
    /// <inheritdoc/>
    public class TextSorter : ITextSorter
    {
        private readonly char[] punctuationsList = new []{ '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '?', '@', '[', '\\', ']', '^', '_', '`', '{', '|', '}', '~'};

        /// <inheritdoc/>
        public IEnumerable<string> Sort(string text, SortOption option)
        {
            List<string> result;
            
            switch (option)
            {
                case SortOption.Alphabetically:
                    result = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    result = result.Select(c => c.TrimEnd(punctuationsList)).ToList();
                    result.Sort();
                    return result;
                case SortOption.WordLength:
                    result = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    result = result.Select(c => c.TrimEnd(punctuationsList)).ToList();
                    result = result.OrderBy(x => x.Length).ToList();                    
                    return result;
                    case SortOption.SentenceLength:
                    result = text.Split(new string[] { ". " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    result = result.Select(c => c.TrimEnd(new[] { '.' })).ToList();
                    result = result.OrderBy(x => x.Length).ToList();
                    return result;
                default:
                    throw new NotSupportedException();
            }
            
        }
    }
}