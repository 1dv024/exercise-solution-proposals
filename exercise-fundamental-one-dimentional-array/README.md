# Lösningsförslag

## Fundamental endimensionell array

<ul">
  <li><a href="https://github.com/1dv024/exercise-fundamental-one-dimentional-array">https://github.com/1dv024/exercise-fundamental-one-dimentional-array</a></li>
</ul>

### Diskussion

```c#
using System;

namespace FundamentalOneDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa och initiera en array med fem heltal.
            int[] values = { 10, 23, 5, 1, 15 };

            // Loopa igenom arrayen...
            for (int i = 0; i < values.Length; ++i)
            {
                // ...och skrive ut varje elements värde.
                Console.Write($"{values[i]} ");
            }
            Console.WriteLine();

            // Hämta ut det andra värdet, dubblera det
            // och tilldela det andra elementet det nya värdet.
            int temp = values[1];
            temp = temp * 2;
            values[1] = temp;

            // Samma resultat som ovan men enklare(?).
            // OBS! Det sista elementet har index 4 då
            //      arrayen innhåller fem element.
            values[4] *= 2;

            // Loopa igenom arrayen...
            foreach (int value in values)
            {
                // ...och skrive ut varje elements värde.
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
