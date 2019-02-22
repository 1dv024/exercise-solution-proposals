# Lösningsförslag

## Uppgift

[Statisk addition](https://coursepress.gitbook.io/1dv024/ovningsuppgifter/del-1/statisk-addition)

## Diskussion

### MyMath.cs

```c#
using System;

namespace StaticAdding
{
    static class MyMath
    {
        public static int Add(int op1, int op2)
        {
            Console.WriteLine(
                ">>> Metoden med signaturen 'Add(int, int)' har anropats");
            return op1 + op2;
        }

        public static double Add(double op1, double op2)
        {
            Console.WriteLine(
                ">>> Metoden med signaturen 'Add(double, double)' har anropats");
            return op1 + op2;
        }
    }
}
```

### Konsolfönster

```shell
>>> Metoden med signaturen 'Add(int, int)' har anropats
Summan är: 579

>>> Metoden med signaturen 'Add(double, double)' har anropats
Summan är: 16,41

>>> Metoden med signaturen 'Add(double, double)' har anropats
Summan är: 129,54
```

För att anropa en statisk metod använder du klassens namn, inte en referens till ett objekt. Statiska metoder kan faktiskt bara anropas med hjälp av klassens namn.

Klassens medlemmar begränsas till två statiska metoder varför hela klassen kan ”märkas” som statisk.

Metoden som returnerar ett heltal av typen int har även två parametrar av typen. Summan av parametrarna returneras. Lägg märke till at du inte behöver lagra resultatet i en variabel vars värde returneras utan att det går alldeles utmärkt att returnera resultatet av uttrycket `op1 + op2`. Metoden inleds med en ”debug-utskrift” som skriver ut vilken metod det är som anropats.

Den andra metoden, som också heter `Add`, returnerar ett flyttal av typen `double`. Fungerar i övrigt på samma sätt som metoden som returnerar ett heltal.

Det finns alltså inget som hindrar att metoder har samma namn så länge som dess signaturer skiljer sig åt. Observera att returtypen INTE är en del av signaturen.