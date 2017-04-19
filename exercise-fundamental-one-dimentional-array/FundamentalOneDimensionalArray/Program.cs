using System;

namespace FundamentalOneDimensionalArray
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
            // Create and initiate an array of five integers.
            int[] values = { 10, 23, 5, 1, 15 };

            // Iterate through the array...
            for (int i = 0; i < values.Length; ++i)
            {
                // ...and display each element's value.
                Console.Write($"{values[i]} ");
            }
            Console.WriteLine();

            // Get the value of the second element, double it
            // and assign the new value to the second element.
            int temp = values[1];
            temp = temp * 2;
            values[1] = temp;

            // The same as above, apart for the index of the element,
            // but much more simple, or?
            values[4] *= 2;

            // Iterate through the array...
            foreach (int value in values)
            {
                // ...and display each element's value.
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }
}
