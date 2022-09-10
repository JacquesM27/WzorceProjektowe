using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class WagonCar : Car
    {
        public override string ToString()
        {
            return "This is wagon car\n" + base.ToString();
        }
    }
}
