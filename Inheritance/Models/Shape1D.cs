using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal abstract class Shape1D : Shape
    {
        public int Width { get; private set; }

        //base - wywołanie konstruktora klasy bazowej
        public Shape1D(string name, int width) : base(name)
        {
            Width = width;
        }

        public override string ToString()
        {
            return $"{base.ToString()} o szerokości {Width}";
        }

    }
}
