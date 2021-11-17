# Portfolioeintrag zum Vocabulary Tester
Dieses Programm ist im Lernatelier entstanden, einem Fach in der Informatikmittelschule, in dem wir eigene Projekte programmieren dürfen. Unsere Vierergruppe hat mit C# ein Programm geschrieben, bei dem der Nutzer Wörter übersetzen kann.

### Ziel
Ich möchte erklären, wie Listen in C# funktionieren.

### Erklärung
Bei einer Liste muss man, anders als beim Array, bei der Initialisierung nur den Datentyp eingeben, der Index, also die Anzahl Elemente, spielt keine Rolle. Es gäbe auch noch eine ArrayList, bei der muss man nicht mal das angeben. Damit man eine Liste initialisieren kann, muss man ganz oben `using System.Collections.Generic;` schreiben und dann: `List<int> listName = new List<int>;`, wobei `int` durch einen beliebigen Datentyp ersetzt werden kann.
Es gibt list.Remove(element) und list.RemoveAt(index).

### Code Anwendungsbeispiel
```csharp
using System;
using System.Collections.Generic;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            
            while (!list.Contains(5))
            {
                list.Add(new Random().Next(0,10));
                int lastIndex = list.Count - 1;
                Console.Write(list[lastIndex]);
                System.Threading.Thread.Sleep(300);
            }

            list.Remove(5);
            Console.WriteLine();

            foreach (int item in list)
            {
                Console.Write(item);
                System.Threading.Thread.Sleep(300);
            }
            Console.ReadLine();
        }
    }
}
```
Hier ist ein Programm, das eine Liste erstellt und so lange Zufallszahlen zwischen 0 und 10 ausgibt, bis eine fünf kommt. Es entfernt die fünf und die Listewird nochmals ohne sie angezeigt.

### Video


### Verifikation
Ich habe mein Ziel im Abschnitt "Erklärung" erreicht.

### Reflexion
Ich hatte Schwierigkeiten, passende Testfälle zu finden. Die Gruppenarbeit fand ich schwierig, weil wir zum Teil die gleichen Sachen gemacht hatten oder uns falsch verstanden haben. Ich versuche nächstes Mal, mehr auf andere zuzugehen und mit ihnen zu sprechen.
