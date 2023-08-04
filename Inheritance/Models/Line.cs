﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Line : Shape1D, IColor
    {
        public Line(int width) : base("Linia", width)
        {
        }

        public string Color { get; set; }
    }
}
