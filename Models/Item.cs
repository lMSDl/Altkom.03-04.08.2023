//namespace - przestrzeń nazw, czyli adres pod którym "mieszka" klasa. Namepsace używany w "using"
namespace Models
{
    //public - modyfikator dostępu - oznacza, że z klasy możemy korzystać wszędzie
    //class - szablon opisujący zachowania i cechy obiektów (instancji klas), które są wytwarzane na jej podstawie 
    //nazwa klasy (pełna nazwa klasy: namespace + nazwa klasy)
    public class Item
    {
        //pole klasy (field) / zmienną globalną
        //brak modyfikatora dostępu == private - oznacza dostęp tylko dla elementów danej klasy
        // pola zazwyczaj są prywatne ze względu na hermetyzację, a dostęp realizowany jest przez metody getter setter
        private int myInt;

        //setter do ustawienia wartości pola myInt - metoda przyjmuje jako poarametr wartość, która zostanie wpisana do pola
        //schemat sygnatury metody: <modyfikator dostępu> <typ zwracany> <nazwa funkcji>(<opcjonalne parametry>)
        public void SetMyInt(int userValue)
        {
            myInt = userValue;
        }

        //getter do pobierania wartości pola myInt - metoda zwracająca typ zgodny z typem pola
        public int GetMyInt()
        {
            //return instrukcja zwracająca wynik metody - typ obiektu zwracanego musi być zgodny z sygnaturą metody
            return myInt;
        }





        //Property

        //auto-property
        //właściwość integruje w sobie pole i metody dostępowe (getter i setter)
        //możliwość zmiany modyfikatora dostępu dla gettera lub settera
        public string Description { get; /*private*/ set; }



        //full-property
        private int quantity;
        public int Quantity
        {            
            //getter wbudowany w property
            get 
            { 
                return quantity;
            }
            //setter wbudowany w property - posiada niejawny parametr o nazwie value
            set
            {
                if (value < 0)
                {
                    quantity = 0;
                }
                else
                {
                    quantity = value;
                }
            }
        }



        private void SthMethod()
        {
            int sthInt = 5;
            myInt = 5;
        }
        private void AnotherMethod()
        {
            myInt = 6;
            //sthInt = 2;
        }
    }

}
