using System;

namespace CoolTemperatureConverter
{
    /// <summary>
    /// Represents the main place where the program starts the execution.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The starting point of the application.
        /// </summary>
        static void Main()
        {
            // Declare variables.
            double celsius;
            double fahrenheit;

            // Get the temperature in Fahrenheit from the user.
            Console.Write("Ange temperaturen i grader Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            // Convert from Fahrenheit to Celcius.
            celsius = (fahrenheit - 32) * 5 / 9;

            // Display the result.
            Console.WriteLine($"Temperaturen {fahrenheit} °F motsvarar {celsius:f1} °C.");

            Console.Write(Environment.NewLine + "Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
