﻿int a = 11;
int b = 4;
int c;

c = a + b;
Console.WriteLine($"{a} + {b} = {c}");
c = a - b;
Console.WriteLine($"{a} - {b} = {c}");
c = a * b;
Console.WriteLine($"{a} * {b} = {c}");
c = a / b; //część dziesiętna jest ucięta
Console.WriteLine($"{a} / {b} = {c}");
c = a % b; //reszta z dzielenia
Console.WriteLine($"{a} % {b} = {c}");

float aa = 11f;
float bb = 4.0f;
float cc;

cc = aa + bb;
Console.WriteLine($"{aa} + {bb} = {cc}");
cc = aa - bb;
Console.WriteLine($"{aa} - {bb} = {cc}");
cc = aa * bb;
Console.WriteLine($"{aa} * {bb} = {cc}");
cc = aa / bb;
Console.WriteLine($"{aa} / {bb} = {cc}");

// kolejność działań zgodna z zasadami matematyki
cc = 2 + 2 * 2;
Console.WriteLine(cc);

cc = (2 + 2) * 2;
Console.WriteLine(cc);


Console.WriteLine($"short min:{short.MinValue} max:{short.MaxValue}");
Console.WriteLine($"int min:{int.MinValue} max:{int.MaxValue}");
Console.WriteLine($"long min:{long.MinValue} max:{long.MaxValue}");

Console.WriteLine($"float min:{float.MinValue} max:{float.MaxValue}");
Console.WriteLine($"double min:{double.MinValue} max:{double.MaxValue}");
Console.WriteLine($"decimal min:{decimal.MinValue} max:{decimal.MaxValue}");

//dzielenie int przez float/double/decimal (albo odrwotnie) daje wynik w typie o wyższej precyzji
Console.WriteLine(5 / 3.3f);
Console.WriteLine(5 / 3.3d);
Console.WriteLine(5 / 3.3m);


//zaokrąglanie wartości
Console.WriteLine(Math.Round(2.5));
Console.WriteLine(Math.Round(3.5));

Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
Console.WriteLine(Math.Round(3.5, MidpointRounding.AwayFromZero));





void StringDemo()
{

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

    //odczytujemy dane od uzytkjownia z konsoli
    //czytamy całą linię, czyli do znaku nowej linii (enter)
    targetVariable = Console.ReadLine();
    helloWorldValue = $"{helloVariable}, {targetVariable}!!!";
    Console.WriteLine(helloWorldValue);

    //zmiuana wielkości liter na małe (lower) albo duże (upper)
    string lowerHelloWorldVariable = helloWorldValue.ToLower();
    Console.WriteLine(lowerHelloWorldVariable);
    Console.WriteLine(helloWorldValue.ToUpper());

    Console.WriteLine(helloWorldValue);
    Console.WriteLine(lowerHelloWorldVariable);

    //zastępowanie znaków stringa
    Console.WriteLine(helloWorldValue.Replace("!!!", "???"));
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

}