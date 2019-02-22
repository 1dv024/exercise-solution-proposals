# Lösningsförslag

## Uppgift

[!Häftig temperaturomvandling](https://coursepress.gitbook.io/1dv024/ovningsuppgifter/del-1/haftig-temperaturomvandling)

## Diskussion

```c#
using System;

namespace CoolTemperatureConverter
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
            // Declare variables.
            double celsius;
            double fahrenheit;

            // Get the temperature in Fahrenheit from the user.
            Console.Write("Ange temperaturen i grader Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            // Convert from Fahrenheit to Celsius.
            celsius = (fahrenheit - 32) * 5 / 9;

            // Display the result.
            Console.WriteLine($"Temperaturen {fahrenheit} °F motsvarar {celsius:f1} °C.");
        }
    }
}
```

Värt att notera är att du inte behöver ta någon speciell hänsyn till divisionen av `5 / 9` (som ju ser ut som en heltalsdivision med värdet 0). Varför? Det är faktiskt inte någon heltalsdivision eftersom multiplikationen utförs först. Ett värde av typen `double` (genom variabeln `fahrenheit`) är inblandad i multiplikationen vilket resulterar i ett värde av typen `double`.

Så här utförs beräkningen om talet `73` matas in, d.v.s. att variabeln `fahrenheit` tilldelas värdet `73.0`:

1. `(fahrenheit – 32) → 73.0 – 32 = 41.0`,
2. Resultatet från punkt 1 `* 5 → 41.0 * 5 = 205.0`,
3. Resultatet från punkt 2 `/ 9 → 205.0 / 9 = 22,777777777777777777777777778`.

Det beräknade värdet avrundas sedan till en decimals onoggrannhet i samband med presentationen.

```shell
Ange temperaturen i grader Fahrenheit: 73
Temperaturen 73 ºF motsvarar 22,8 ºC.
```