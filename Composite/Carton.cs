using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Carton : Product
    {
        protected List<OrderElement> elements = new();
        public Carton(string name) : base(name)
        {
        }

        public override decimal CalculatePrice()
        {
            TypeName();
            //decimal price = 0;
            //foreach (OrderElement element in elements)
            //{
            //    price += element.CalculatePrice();
            //}
            decimal price = elements.Sum(x => x.CalculatePrice())+1;
            return price;
        }

        public override void TypeName()
        {
            Console.WriteLine("I'm Carton - my price equals 1");
        }

        public override void Add(OrderElement orderElement)
        {
            elements.Add(orderElement);
        }

        public override void Remove(OrderElement orderElement)
        {
            elements.Remove(orderElement);
        }
    }
}
