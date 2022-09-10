using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class VictorianTable : ITable
    {
        public string PartyTime(ISofa sofa, IChair chair)
        {
            return "(⌐■v■) (ꗞᗝꗞ)";
        }

        public string PutCoffeHere()
        {
            return "This table has broken leg!";
        }

        
    }
}
