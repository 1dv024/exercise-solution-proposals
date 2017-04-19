using System;

namespace FundamentalOneDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapar och initierar en array med fem heltal.
            int[] values = { 10, 23, 5, 1, 15 };

            // Loopar igenom arrayen...
            for (int i = 0; i < values.Length; ++i)
            {
                // ...och skriver ut varje elements värde.
                Console.Write($"{values[i]} ");
            }
            Console.WriteLine();

            // Hämtar ut det andra värdet, dubblerar det
            // och tilldelar det andra elementet det nya värdet.
            int temp = values[1];
            temp = temp * 2;
            values[1] = temp;

            // Samma resultat som ovan men enklare(?).
            // OBS! Det sista elementet har index 4 då
            //      arrayen innhåller fem element.
            values[4] *= 2;

            // Loopar igenom arrayen...
            foreach (int value in values)
            {
                // ...och skriver ut varje elements värde.
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }
}
