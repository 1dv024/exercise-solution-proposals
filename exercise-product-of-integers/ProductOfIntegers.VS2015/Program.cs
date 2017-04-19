using System;

namespace ProductOfIntegers
{
    class Program
    {
        /// <summary>
        /// Startpunkt för applikationen.
        /// </summary>
        static void Main()
        {
            // Definiera variabel för produkten.
            long product = 1;

            // Bestäm produkten av alla heltal i det 
            // slutna intervallet mellan 1 och 20.
            for (int i = 1; i <= 20; i++)
            {
                product *= i;
            }

            // Presentera resultatet.
            Console.WriteLine($"Produkten av alla heltal mellan 1 och 20 är {product}.");
        }
    }
}
