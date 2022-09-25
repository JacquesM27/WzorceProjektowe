using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    internal class Product : OrderElement
    {
        private readonly decimal price;
        public Product(string name) : base(name)
        {
            Random random = new();
            price = random.Next(11, 15);
        }

        public override decimal CalculatePrice()
        {
            TypeName();
            return price;
        }

        public override void TypeName()
        {
            Console.WriteLine($"I'm product - {Name} - my price equals {price}");
        }
    }
}
