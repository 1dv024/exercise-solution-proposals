using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ParallelWordFrequencyAnalyzer
{
    /// <summary>
    /// 
    /// </summary>
    public static class Repository
    {
        /// <summary>
        /// The file to read from.
        /// </summary>
        public static string Source { get; set; }

        /// <summary>
        /// The file to write to.
        /// </summary>
        public static string Destination { get; set; }

        /// <summary>
        /// Reads all lines of the file into a string collection.
        /// </summary>
        /// <returns>A string collection containing all lines of the file.</returns>
        public static IEnumerable<string> GetAll()
        {
            return File.ReadAllLines(Source);
        }

        /// <summary>
        /// Writes a collection of strings to a file.
        /// </summary>
        /// <param name="contents">The lines to write to the file</param>
        public static void SaveAll(IEnumerable<string> contents)
        {
            var json = JsonConvert.SerializeObject(contents,Formatting.Indented);
            File.WriteAllText(Destination, json);
        }
    }
}
