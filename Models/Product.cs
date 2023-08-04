using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        //metoda konstrukcyjna (konstruktor) - bezparametrowa
        //brak typu zwracanego i nazwa taka sama jak nazwa klasy
        //jeśli klasa nie ma żadnego konstruktora, to konstruktor bezmarametrowy zostanie do niej automatycznie dodany
        public Product()
        {
        }

        //konstruktor parametrowy - służy do zapewnienie klasie wartości początkowych dla pól i właściwości
        //jeśli w klasie występuje jakikolwiek konstruktor z parametrami, to konstruktor domyślny (bezparametrowy) nie zostanie dodany
        //chcąc posiadać też konsturktor bezparametrowy musimy go jawnie utworzyć
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }


        public string Name { get; set; }
        public decimal Price { get; set; }



        public string ShowDetails()
        {
            return $"{Name}: {Price:0.#0} zł";
        }
    }
}
