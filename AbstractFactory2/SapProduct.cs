using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class SapProduct : IProduct
    {
        public void CheckAvailability()
        {
            Console.WriteLine("SAP Product available");
        }
    }
}
