using System;
using System.IO;
using System.Linq;

namespace SimplestWordFrequencyAnalyzer
{
    /// <summary>
    /// Contains the application entry point.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Starting point of the application.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            try
            {
                // Reads the text file.
                Console.WriteLine($"Reads the text file '{args[0]}'.");
                var lines = File.ReadAllLines(args[0]);

                Console.WriteLine("Analyzes the content.");

                // Gets the total number of words.
                var words = TextAnalyzer.ExtractWords(lines).ToArray();
                Console.WriteLine($"Found {words.Count()} words.");

                // Gets the number of unique words.
                var frequencyOrdered = TextAnalyzer.GetWordFrequency(words)
                    .OrderByDescending(kvp => kvp.Value);
                Console.WriteLine($"Found {frequencyOrdered.Count()} unique words.");

                // Gets the five most frequent words.
                var fifthWordCount = frequencyOrdered.Take(5).Last().Value;
                var mostFrequent = frequencyOrdered
                    .TakeWhile(x => x.Value >= fifthWordCount)
                    .Select(x => x.Key);
                var output = $"The most frequent words are '{string.Join("', '", mostFrequent)}'.";
                var index = output.LastIndexOf(", ", StringComparison.Ordinal);
                output = output.Remove(index, 2).Insert(index, " and ");
                Console.WriteLine(output);

                // Wrtites the word count to text file.
                Console.WriteLine($"Writes the word occurence count to the text file '{args[1]}'.");
                var alphabeticallyOrdered = frequencyOrdered
                    .OrderBy(kvp => kvp.Key)
                    .Select(x => x.ToString());
                File.WriteAllLines(args[1], alphabeticallyOrdered);

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}
