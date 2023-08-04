using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }



        public string ShowDetails()
        {
            return $"{Name}: {Price:#.#0} zł";
        }
    }
}
