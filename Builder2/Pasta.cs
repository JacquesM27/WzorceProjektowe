using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    internal class Pasta : Dinner
    {
        public override decimal CalculatePrice()
        {
            decimal price = 20;
            Random random = new();
            int tax = random.Next(1,11);
            return price + tax;
        }
    }
}
