using System;
using System.IO;

namespace LastMessageFromTitanic
{
    /// <summary>
    /// Represents the main place where the program starts the execution.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The starting point of the application.
        /// </summary>
        /// <param name="args">Array containing arguments passed to the application.</param>
        static void Main(string[] args)
        {
            try
            {
                // Open the text file, passed to the application, and
                // read it line by line. Convert each line from text
                // to Morse codes and play the codes.
                using (var file = File.OpenRead(args[0]))
                using (var reader = new StreamReader(file))
                {
                    var morseCode = new MorseCode();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine($"--> {line}");
                        morseCode.Play(line);
                        Console.WriteLine(Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}
