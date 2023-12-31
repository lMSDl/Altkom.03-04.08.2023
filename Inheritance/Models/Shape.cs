﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{    
    
    //klasa abstrakcyjna - baza dla innych klas, nie można utworzyć jej instancji
    //każda klasa dziedziczy niejawnie po klasie Object
    internal abstract class Shape /*: Object*/ 
    {
        private string _name; 
        
        public Shape(string name)
        {
            _name = name;
        }

        //override - nadpisujemy metodę z klasy bazowej (które są abstract lub virtual)
        public override string ToString()
        {
            return _name;
        }

    }
}
