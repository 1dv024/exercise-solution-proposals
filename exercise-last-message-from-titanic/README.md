# <i class="fa fa-flask"></i> Lösningsförslag

## <i class="fa fa-laptop"></i> Sista meddelandet från Titanic

<ul class="fa-ul fa-border exercise-info">
<li><i class="fa-li fa fa-github"></i><a href="https://github.com/1dv024/exercise-last-message-from-titanic">https://github.com/1dv024/exercise-last-message-from-titanic</a></li>
</ul>

### Diskussion

```c#
using System;
using System.IO;

namespace LastMessageFromTitanic
{
    /// <summary>
    /// Represents the main place where the program starts the execution.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The starting point of the application.
        /// </summary>
        /// <param name="args">Array containing arguments passed to the application.</param>
        static void Main(string[] args)
        {
            try
            {
                // Open the text file, passed to the application, and
                // read it line by line. Convert each line from text
                // to Morse codes and play the codes.
                using (var file = File.OpenRead(args[0]))
                using (var reader = new StreamReader(file))
                {
                    var morseCode = new MorseCode();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine($"--> {line}");
                        morseCode.Play(line);
                        Console.WriteLine(Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}
```

Som synes är filhantering inte på något sätt komplicerat. Det viktigaste du behöver ta med dig från denna övning är att **alltid använda ett using-block** då du arbetar med resurser så som filer. 

Förstås är också felhanteringen viktig! Mer eller mindre beroende på aktuell tillämpning men oftast mer, eftersom det finns en hel del detaljer som kan gå fel när du sysslar med filer...
