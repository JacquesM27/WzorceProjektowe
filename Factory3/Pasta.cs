using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory3
{
    internal class Pasta : Dinner
    {
        public override string Ingredients()
        {
            return "penne, tomato sauce, meat";
        }
    }
}
