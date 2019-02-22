# Lösningsförslag

## Uppgift

[Produkten av heltal](https://coursepress.gitbook.io/1dv024/ovningsuppgifter/del-1/produkten-av-heltal)

## Diskussion

```c#
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
```

Variabeln `product`, som initieras till `1`, håller ordning på produkten, d.v.s. resultatet av en multiplikation. Den kan inte vara av typen `int` eftersom `int` ”bara” kan hantera tal upp till 2147483647. Försöker du lagra ett större tal än så ”slår det runt” och värdet kan bli negativt. Typen `long` klarar däremot `9223372036854775807` vilket räcker i denna uppgift.

Med hjälp av `for`-satsen multipliceras talen 1-20. `for`-satsen börjar med värdet `1` som multipliceras med `product`. Sedan ökas värdet som `i` har med `1` så nästa gång multipliceras `product` med `2`. Värdet `i` ökas därefter med `1` och blir då `3` som multipliceras med `product`. Så håller det på tills `i` får värdet `21` vilket avslutar `for`-satsen eftersom `21` inte är mindre eller lika med `20`. Därefter presenteras resultatet.
