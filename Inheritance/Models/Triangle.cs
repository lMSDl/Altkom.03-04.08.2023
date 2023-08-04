using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Triangle : Shape2D
    {
        public int Angle { get; set; }
        public Triangle(int width, int height, int angle) : base("Trójkąt", width, height)
        {
            Angle = angle;
        }
        public override string ToString()
        {
            return $"{base.ToString()} oraz kącie między bokami {Angle}";
        }

        public override double CalculateArea()
        {
            return 0.5 *  Width * Height * Math.Sin(Angle);
        }
    }
}
