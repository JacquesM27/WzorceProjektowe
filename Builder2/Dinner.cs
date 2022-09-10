using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    public abstract class Dinner : IDinner
    {
        protected List<string> ingredients = new();

        public abstract decimal CalculatePrice();
    }
}
