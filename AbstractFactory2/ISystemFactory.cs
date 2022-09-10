using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal interface ISystemFactory
    {
        ICustomer CreateCustomer();
        IProduct CreateProduct();
        IOrder CreateOrder(ICustomer customer, IEnumerable<IProduct> products);
        IInvoice CreateInvoice(IOrder order);
    }
}
