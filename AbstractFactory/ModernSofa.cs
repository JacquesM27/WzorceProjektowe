using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ModernSofa : ISofa
    {
        public string LieDownHere()
        {
            return "Yes, this modern sofa is fine";
        }
    }
}
