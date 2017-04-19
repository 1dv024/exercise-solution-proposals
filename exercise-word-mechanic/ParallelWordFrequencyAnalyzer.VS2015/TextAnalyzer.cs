using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParallelWordFrequencyAnalyzer
{
    /// <summary>
    /// Represents a text analyser.
    /// </summary>
    public static class TextAnalyzer
    {
        /// <summary>
        /// Regular expression to split a string into words.
        /// </summary>
        private static readonly Regex Rgx = new Regex(@"\W+");

        /// <summary>
        /// Returns a dictionary containing the word count.
        /// </summary>
        /// <param name="words">Specifies the words to be counted.</param>
        /// <returns></returns>
        public static IDictionary<string, int> GetWordFrequency(IEnumerable<string> words)
        {
            var dictionary = new ConcurrentDictionary<string, int>();

            Parallel.ForEach(words, (word) =>
                dictionary.AddOrUpdate(word, 1, (k, v) => v + 1));

            return dictionary;
        }

        /// <summary>
        /// Extracts all the words, not containing a number, from a string.
        /// </summary>
        /// <param name="line">The string to extract words from.</param>
        /// <returns></returns>
        public static IEnumerable<string> ExtractWords(string line) => 
            Rgx.Split(line)
                .Where(word => !string.IsNullOrWhiteSpace(word)
                           && !Regex.IsMatch(word, @"\d"))
                .Select(word => word.ToLower());

        /// <summary>
        /// Extracts all the words, not containing a number, from a collection of strings.
        /// </summary>
        /// <param name="lines">Specifies the strings to extract words from.</param>
        /// <returns></returns>
        public static IEnumerable<string> ExtractWords(IEnumerable<string> lines) => 
            lines.Select(ExtractWords).SelectMany(x => x);
    }
}
