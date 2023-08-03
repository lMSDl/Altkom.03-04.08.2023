
//deklaracja zmiennej lokalej o typie string (ciąg znaków) i nazwie helloWorldValue (nazwa dowolna)
// ; - oznacza koniec instrukcji
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