using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface ITable
    {
        string PutCoffeHere();
        string PartyTime(ISofa sofa, IChair chair);
    }

}
