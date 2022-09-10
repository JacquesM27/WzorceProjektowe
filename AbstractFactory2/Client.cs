using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    internal class Client
    {

        public void DoProcess(ISystemFactory factory)
        {
            Console.WriteLine("\nMake products");
            var productA = factory.CreateProduct();
            productA.CheckAvailability();
            var productB = factory.CreateProduct();
            productB.CheckAvailability();

            var products = new List<IProduct>
            {
                productA, productB
            };

            Console.WriteLine("\nMake a customer");
            var customer = factory.CreateCustomer();
            customer.CheckDebt();

            Console.WriteLine("\nMake an order");
            var order = factory.CreateOrder(customer, products);
            order.CheckState();

            Console.WriteLine("\nMake an invoice");
            var invoice = factory.CreateInvoice(order);
            invoice.AccountInvoice();
        }
    }
}
