using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class SapFactory : ISystemFactory
    {
        public ICustomer CreateCustomer()
        {
            return new SapCustomer();
        }

        public IInvoice CreateInvoice(IOrder order)
        {
            return new SapInvoice();
        }

        public IOrder CreateOrder(ICustomer customer, IEnumerable<IProduct> products)
        {
            return new SapOrder();
        }

        public IProduct CreateProduct()
        {
            return new SapProduct();
        }
    }
}
