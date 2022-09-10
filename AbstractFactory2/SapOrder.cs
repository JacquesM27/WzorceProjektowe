using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class SapOrder : IOrder
    {
        public void CheckState()
        {
            Console.WriteLine("Sap Order: Order is completed. Make invoice.");
        }
    }
}
