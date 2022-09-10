using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class WaproInvoice : IInvoice
    {
        public void AccountInvoice()
        {
            Console.WriteLine("Wapro Invoice: Invoice accounted.");
        }
    }
}
