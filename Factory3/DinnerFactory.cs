using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory3
{
    internal class DinnerFactory
    {
        public Dinner CreateDinner(DinnerType type)
        {
            return type switch
            {
                DinnerType.Pizza => new Pizza(),
                DinnerType.Pasta => new Pasta(),
                DinnerType.Lasagne => new Lasagne(),
                _ => throw new ArgumentException($"Dinner {type} is not recognized")
            };
        }
    }
}
