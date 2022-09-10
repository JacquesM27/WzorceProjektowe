using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ITable CreateTable();
        
    }
}
