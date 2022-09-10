using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory3
{
    internal abstract class Dinner
    {
        public decimal Price { get; set; }
        public decimal Calories { get; set; }

        public abstract string Ingredients();
    }
}
