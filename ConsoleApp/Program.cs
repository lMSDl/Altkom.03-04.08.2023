
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


