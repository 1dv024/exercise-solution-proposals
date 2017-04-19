using System;

namespace StaticAdding
{
    /// <summary>
    /// Represents a simple adding machine.
    /// </summary>
    static class MyMath
    {
        /// <summary>
        /// Returns the sum of two values.
        /// </summary>
        /// <param name="op1">The value to add.</param>
        /// <param name="op2">The value to add.</param>
        /// <returns>The value that is the result of the addition operation.</returns>
        public static int Add(int op1, int op2)
        {
            #if DEBUG
            Console.WriteLine(
                ">>> Metoden med signaturen 'Add(int, int)' har anropats");
            #endif

            return op1 + op2;
        }

        /// <summary>
        /// Returns the sum of two values.
        /// </summary>
        /// <param name="op1">The value to add.</param>
        /// <param name="op2">The value to add.</param>
        /// <returns>The value that is the result of the addition operation.</returns>
        public static double Add(double op1, double op2)
        {
            #if DEBUG
            Console.WriteLine(
                ">>> Metoden med signaturen 'Add(double, double)' har anropats");
            #endif
            
            return op1 + op2;
        }
    }
}
