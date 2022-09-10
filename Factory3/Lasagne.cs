using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory3
{
    internal class Lasagne : Dinner
    {
        public override string Ingredients()
        {
            return "lasagne pasta, tomato sauce, meat";
        }
    }
}
