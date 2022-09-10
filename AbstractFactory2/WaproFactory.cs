using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class WaproFactory : ISystemFactory
    {
        public ICustomer CreateCustomer()
        {
            return new WaproCustomer();
        }

        public IInvoice CreateInvoice(IOrder order)
        {
            return new WaproInvoice();
        }

        public IOrder CreateOrder(ICustomer customer, IEnumerable<IProduct> products)
        {
            return new WaproOrder();
        }

        public IProduct CreateProduct()
        {
            return new WaproProduct();
        }
    }
}
