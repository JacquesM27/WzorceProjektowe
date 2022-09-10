using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class CoupeCar : Car
    {

        public override string ToString()
        {
            return "This is coupe car\n" + base.ToString();
        }
    }
}
