

void PrecisionDemo()
{
    float floatValue = 123456.768f;

    Console.WriteLine($"{floatValue:000 ### ###.### 000}");

    double floatAsDoubleValue = 123456.768f;
    double doubleValue = 123456.768d;
    Console.WriteLine(floatValue);
    Console.WriteLine(doubleValue);

    doubleValue = 123456789.123456789;
    decimal decimalValue = 123456789.123456789m;
    Console.WriteLine(doubleValue);
    Console.WriteLine(decimalValue);

}


void SwitchDemo()
{
    string inputString = Console.ReadLine();
    //int intValue = int.Parse(inputString);


    int intValue;
    if (!int.TryParse(inputString, out intValue)) // ! - negacja; out - parametr wyjściowy
    {
        Console.WriteLine("Podana wartość nie jest liczbą");
    }
    else
    {


        if (intValue > 0)
        {
            Console.WriteLine($"Wartość {intValue} jest większa od 0");
        }
        else if (intValue < 0)
        {
            Console.WriteLine($"Wartość {intValue} jest mniejsza od 0");
        }
        else
        {
            Console.WriteLine($"Wartość {intValue} jest równa od 0");
        }

        //switch przyjmuje parametr, który jest porównywany z listą przypadków
        //każdy przypadek musi się kończyć instrukcją: break;
        switch (intValue)
        {
            case > 0:
                Console.WriteLine($"Wartość {intValue} jest większa od 0");
                break;
            case < 0:
                Console.WriteLine($"Wartość {intValue} jest mniejsza od 0");
                break;
            //default jest opcjonalny i wywoływany gdy nie znaleziono innego dopasowania
            default:
                Console.WriteLine($"Wartość {intValue} jest równa od 0");
                break;
        }
    }


    Console.WriteLine("Jak masz na imię?");
    inputString = Console.ReadLine();

    switch (inputString)
    {
        case "":
            Console.WriteLine("Szkoda, że nie chcesz podać swojego imienia");
            break;
        case "Alexa":
        case "Siri":
        case "Bixby":
            Console.WriteLine("Hej, masz na imię tak jak elektroniczny asystent");
            break;
        default:
            Console.WriteLine($"Cześć {inputString}! Jak się masz?");
            break;
    }

}


void IfDemo()
{
    string inputString = Console.ReadLine();


    bool result1 = inputString == "ala ma kota"; // == porównanie
    bool result2 = inputString != "Baba Jaga"; // != - różne

    Console.WriteLine(result1);
    Console.WriteLine(result2);

    int result3 = inputString.CompareTo("k");

    bool result31 = result3 == 0;
    bool result32 = result3 > 0;
    bool result33 = result3 < 0;

    Console.WriteLine(result31);
    Console.WriteLine(result32);
    Console.WriteLine(result33);


    if (result3 == 0)
    {
        Console.WriteLine("wartości są takie same");
    }

    if (result3 > 0)
    {
        Console.WriteLine($"{inputString} jest za literą k");
    }

    if (result3 < 0)
    {
        Console.WriteLine($"{inputString} jest przed literą k");
    }

    if (result3 == 0)
    {
        Console.WriteLine("wartości są takie same");
    }
    else if (result3 > 0)
    {
        Console.WriteLine($"{inputString} jest za literą k");
    }
    else if (result3 < 0)
    {
        Console.WriteLine($"{inputString} jest przed literą k");
    }




    //<5; 10)
    inputString = Console.ReadLine();
    int intValue = int.Parse(inputString);

    if (intValue > 5 || intValue == 5) // || - logiczne lub
    {
        if (intValue < 10)
        {
            Console.WriteLine("Wartość należy do przedziału <5; 10)");
        }
        else
        {
            Console.WriteLine("Wartość jest spoza przedziału");
        }
    }
    else
    {
        Console.WriteLine("Wartość jest spoza przedziału");
    }



    // >= - większe-równe, <= - mniejsze-równe 
    if (intValue >= 5 && intValue < 10) // && - logiczne i
    {
        Console.WriteLine("Wartość należy do przedziału <5; 10)");
    }
    else
    {
        Console.WriteLine("Wartość jest spoza przedziału");
    }
}


void NumberDemo()
{

    int a = 11;
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
    //zaokrąglanie domyślnie wykorzustyje "financial rounding" / MidpointRounding.ToEven
    Console.WriteLine(Math.Round(2.5));
    Console.WriteLine(Math.Round(3.5));

    Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
    Console.WriteLine(Math.Round(3.5, MidpointRounding.AwayFromZero));




    int intMax = int.MaxValue;
    long longMax = long.MaxValue;


    long longValue = intMax;
    //chcąc przypisać wartość o wyższej precyzji do zmiennej o niższej musimy zastosować rzutowanie
    int intValue = (int)longMax;

    Console.WriteLine(longValue);
    Console.WriteLine(intValue);

    intValue = int.MaxValue;
    Console.WriteLine(intValue);
    intValue = intValue + 1;
    Console.WriteLine(intValue);

    longValue = 128;
    intValue = (int)longValue;
    Console.WriteLine(intValue);

    float floatValue = int.MaxValue;

    Console.WriteLine(floatValue);

    floatValue = (float)double.MaxValue;
    Console.WriteLine(floatValue);


    //parsowanie/konwersja string na int
    string value1 = Console.ReadLine();
    intValue = int.Parse(value1);

    //parsowanie/konwersja string na float
    string value2 = Console.ReadLine();
    floatValue = float.Parse(value2);

    Console.WriteLine(intValue + floatValue);
}



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