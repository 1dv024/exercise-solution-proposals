using System;

namespace ProductOfIntegers
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
            // Declare the variable for the product.
            long product = 1;

            // Determine the product of any integer in 
            // the closed interval between 1 and 20.
            for (int i = 1; i <= 20; i++)
            {
                product *= i;
            }

            // Display the result.
            Console.WriteLine($"Produkten av alla heltal mellan 1 och 20 är {product}.");
        }
    }
}
