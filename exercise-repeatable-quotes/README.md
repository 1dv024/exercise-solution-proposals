# <i class="fa fa-flask"></i> Lösningsförslag

## <i class="fa fa-laptop"></i> Repeterbara citat

<ul class="fa-ul fa-border exercise-info">
  <li><i class="fa-li fa fa-github"></i><a href="https://github.com/1dv024/exercise-repeatable-quotes">https://github.com/1dv024/exercise-repeatable-quotes</a></li>
</ul>

### Diskussion

#### QuoteViewer.cs

```c#
using System;

namespace RepeatableQuotes
{
    public class QuoteViewer
    {
        // Fields
        private int _count;

        // Constructors
        public QuoteViewer()
        {
            // Empty!
        }

        public QuoteViewer(string quote, int count)
        {
            Quote = quote;
            Count = count;
        }

        // Properties
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public string Quote { get; set; }

        // Methods
        public void View()
        {
            Console.WriteLine("-----");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(Quote);
            }
            Console.WriteLine("-----");
        }
    }
}
```

Klassdiagrammets första avsnitt ("_Fields_") ger det två privata fältet `_count` samt dess typ (`int`). I avsnittet "_Properties_" i klassdiagrammet hittar du två publika egenskaper. Egenskapen `Count` kapslar in fältet `_count` (helt i onödan då ingen validering sker). Egenskapen `Quote`, av typen `string`, är em s.k. auto-implmenterad egenskap som inte kapslar in något synligt fält (det läggs faktiskt till ett fält av kompilatorn).

I avsnittet "_Methods_" finns de två konstruktorerna som ska implementeras. Observera att konstruktorer saknar returvärde och måste ha samma namn som klassen. Det som skiljer konstruktorerna åt är deras signaturer, d.v.s. namnet på konstruktorn och dess parameterlista. (Titta gärna i metoden `Main` hur respektive konstruktor används.)

Den publika metoden `View` skriver helt enkelt ut datat, som det privata fältet `_quote` innehåller, `_count` gånger.