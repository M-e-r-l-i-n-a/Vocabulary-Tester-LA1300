# Portfolioeintrag zum Vocabulary Tester
Dieses Programm ist im Lernatelier entstanden, einem Fach in der Informatikmittelschule, in dem wir eigene Projekte programmieren dürfen. Unsere Vierergruppe hat mit C# ein Programm geschrieben, bei dem der Nutzer Wörter übersetzen kann.

### Ziel
Ich möchte erklären, wie Listen in C# funktionieren.

### Erklärung
Bei einer Liste muss man, anders als beim Array, bei der Initialisierung nur den Datentyp eingeben, der Index, also die Anzahl Elemente, spielt keine Rolle. Es gäbe auch noch eine ArrayList, bei der muss man nicht mal das angeben. Die Initialisierung einer Liste sieht so aus: `List<int> listName = new List<int>`, wobei `int` durch einen beliebigen Datentyp ersetzt werden kann.

### Code Anwendungsbeispiel
```csharp
List<int> listName = new List<int>();
while (listName.Count < 20)
if (!listName.Contains(newWord))
    {
        listName.Add(newWord);
        listName.RemoveAt(item);
    }
Console.Write(listName[item]);
```

### Video


### Verifikation
Ich habe mein Ziel im Abschnitt "Erklärung" erreicht.

### Reflexion
Ich hatte Schwierigkeiten, passende Testfälle zu finden. Die Gruppenarbeit fand ich schwierig, weil wir zum Teil die gleichen Sachen gemacht hatten oder uns falsch verstanden haben. Ich versuche nächstes Mal, mehr auf andere zuzugehen und mit ihnen zu sprechen.
