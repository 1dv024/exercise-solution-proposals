# Lösningsförslag

## Uppgift

[Fundamental endimensionell array](https://coursepress.gitbook.io/1dv024/ovningsuppgifter/del-1/fundamental-endimensionell-array)

## Diskussion

```c#
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
```

En array med plats för fem heltal måste skapas och det är det första som sker. Har här valt att skapa och initiera arrayen på en och samma gång. Att skapa och initiera en array kan göras på flera olika sätt förutom sättet som används i lösningen ovan.

```c#
int[] values = new int[5];
values[0] = 10;
values[1] = 23;
values[2] = 5;
values[3] = 1;
values[4] = 15;
```

eller

```c#
int[] values = new int[5] { 10, 23, 5, 1, 15 };
```

eller

```c#
int[] values = new int[] { 10, 23, 5, 1, 15 };
```

Vilket sätt du väljer har ingen betydelse. Slutresultatet blir i alla fall en array med fem element som innehåller heltalen `10`, `23`, `5`, `1` och `15`.

Loopar igenom arrayen, med en `for`-sats, element för element och skriver ut varje elements värde. Använder egenskapen `Length` i villkorsuttrycket för att kunna bestämma antalet element i arrayen. (Observera att variabeln `i` bara är tillgänglig inom `for`-satsen, dess räckvidd (_scope_) är begränsat till blocket där den är deklarerad.)

Det andra värdet i arrayen ligger på index 1 och ska multipliceras med två. Följande algoritm beskriver vad som sker:

1. Värdet kopieras till variabeln `temp`.
2. Värdet `temp` har multipliceras med två.
3. Elementet med index 1 tilldelas värdet `temp` har.

En onödigt omständlig lösning för att multipliceras ett elements värde med två. En mindre omständlig lösning är att använda den sammansatta tilldelningsoperatorn `*=` som hämtar, multiplicerar och tilldelar på en och samma gång. Det görs då det sista elementets värde ska multipliceras med två.

Programmet avslutas med att arrayen skrivs ut på nytt, med hjälp av en `foreach`-sats. Nu med de modifierade värdena. (Observera att elements värden inte kan ändras via variablen `value` som är en del `foreach`-satsen och därmed en "_read-only_" variabel representerande det aktuella elementets värde.)