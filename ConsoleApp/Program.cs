
//deklaracja zmiennej lokalej o typie string (ciąg znaków) i nazwie helloWorldValue (nazwa dowolna)
// ; - oznacza koniec instrukcji
using System.Drawing;

string helloWorldValue;
//inicjalizacja zmiennej - pierwsze przypisanie wartości
helloWorldValue = "Hello, W0rld!";

//deklaracja z inicjalizacją
string helloWorldWithNewLine = "Hello, World!\n";


//Prosimy konsolę, o wypisanie tekstu poprzez wywołanie funkcji Write (funkcje mają zawsze nawiasy)
Console.Write(helloWorldValue);
//funkcja WriteLine stawia automatycznie znak nowej linii na końcu wskazanego tekstu
Console.WriteLine(helloWorldValue);
// \n - ręcznie wstawiamy znak nowej linii
// \ (ukośnik opadający) - aktywacja znaku specjalnego, który następuje po nim
Console.Write(helloWorldWithNewLine);

//przypisanie wartości
helloWorldValue = "Hello, world!";

Console.Write(helloWorldValue);
Console.WriteLine();


string helloVariable = "Hello";
string targetVariable = "Class";

//łączenie stringów za pomocą +
helloWorldValue = helloVariable + ", " + targetVariable + "!";
Console.WriteLine(helloWorldValue);

//łączymy stringi za pomocą statycznej funkcji Concat
helloWorldValue = string.Concat(helloVariable, ", ", targetVariable, "!");
Console.WriteLine(helloWorldValue);

//łączenie stringów za pomocą funkcji format - pierwszy parametr przyjmuje wygląd docelowy, a kolejne perametry to składowe
// {0} {1} - miejsca w które wstawiamy wspomniane wyżej składowe (numer w klamerce oznacza indeks)
string format = "{0}, {1}!";
helloWorldValue = string.Format(format, helloVariable, targetVariable);
Console.WriteLine(helloWorldValue);

helloWorldValue = string.Format(format, helloVariable, "Tom");
Console.WriteLine(helloWorldValue);

//łączenie stringów za pomocą intepolacji (string interpolowany)
helloWorldValue = $"{helloVariable}, {targetVariable}!";
Console.WriteLine(helloWorldValue);

//odczytujemy dane od uzytkjownia z konsoli
//czytamy całą linię, czyli do znaku nowej linii (enter)
targetVariable = Console.ReadLine();
helloWorldValue = $"{helloVariable}, {targetVariable}!!!";
Console.WriteLine(helloWorldValue);

//zmiuana wielkości liter na małe (lower) albo duże (upper)
string lowerHelloWorldVariable = helloWorldValue.ToLower();
Console.WriteLine(lowerHelloWorldVariable);
Console.WriteLine( helloWorldValue.ToUpper() );

Console.WriteLine(helloWorldValue);
Console.WriteLine(lowerHelloWorldVariable);

//zastępowanie znaków stringa
Console.WriteLine(  helloWorldValue.Replace("!!!", "???"));
Console.WriteLine(helloWorldValue);

//wycinanie fragmentów tekstu - podajemy indeks od którego chcemy wyciąć (opcjonalnie ile znaków)
Console.WriteLine(helloWorldValue.Substring(helloWorldValue.Length - 3));
Console.WriteLine(helloWorldValue.Substring(helloVariable.Length + 2, targetVariable.Length));

//usuwanie znaków pustych/białych
targetVariable = Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(targetVariable);
Console.WriteLine(targetVariable.Trim());
Console.WriteLine(targetVariable.TrimEnd());
Console.WriteLine(targetVariable.TrimStart());
Console.WriteLine(targetVariable.Replace(" ", string.Empty));
Console.ResetColor();

