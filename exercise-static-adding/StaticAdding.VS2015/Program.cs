using System;

namespace StaticAdding
{
    class Program
    {
        /// <summary>
        /// Startpunkt för applikationen.
        /// </summary>
        static void Main()
        {
            // Vilken statisk metod anropas?
            int sum = MyMath.Add(123, 456);
            Console.WriteLine($"Summan är: {sum}\n");

            // Vilken statisk metod anropas?
            double anotherSum = MyMath.Add(9.87, 6.54);
            Console.WriteLine($"Summan är: {anotherSum}\n");

            // Vilken statisk metod anropas?
            Console.WriteLine("Summan är: {0}\n", MyMath.Add(123, 6.54));
        }
    }
}
