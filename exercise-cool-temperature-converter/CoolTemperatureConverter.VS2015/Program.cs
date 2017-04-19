using System;

namespace CoolTemperatureConverter
{
    class Program
    {
        /// <summary>
        /// Startpunkt för applikationen.
        /// </summary>
        static void Main()
        {
            // Definiera variabler.
            double celsius;
            double fahrenheit;

            // Hämta temperatur i Fahrenheit från användaren.
            Console.Write("Ange temperaturen i grader Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            // Konvertera Fahrenheit till Celcius.
            celsius = (fahrenheit - 32) * 5 / 9;

            // Presentera resultatet.
            Console.WriteLine($"Temperaturen {fahrenheit} °F motsvarar {celsius:f1} °C.");
        }
    }
}
