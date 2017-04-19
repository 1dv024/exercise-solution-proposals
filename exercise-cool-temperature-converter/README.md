# <i class="fa fa-flask"></i> Lösningsförslag 

## <i class="fa fa-laptop"></i> !Häftig temperaturomvandling
<ul class="fa-ul fa-border exercise-info">
<li><i class="fa-li fa fa-github"></i><a href="https://github.com/1dv024/exercise-cool-temperature-converter">https://github.com/1dv024/exercise-cool-temperature-converter</a></li>
</ul>

### Diskussion

```c#
using System;

namespace CoolTemperatureConverter
{
    class Program
    {
        /// <summary>
        /// Startpunkt för applikationen.
        /// </summary>
        static void Main()
        {
            // Definiera variabler.
            double celsius;
            double fahrenheit;

            // Hämta temperatur i Fahrenheit från användaren.
            Console.Write("Ange temperaturen i grader Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            // Konvertera Fahrenheit till Celcius.
            celsius = (fahrenheit - 32) * 5 / 9;

            // Presentera resultatet.
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

