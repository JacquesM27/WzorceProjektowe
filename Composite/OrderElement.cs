using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class OrderElement
    {
        public string Name { get; set; }

        public OrderElement(string name)
        {
            Name = name;
        }

        public abstract void TypeName();
        public abstract decimal CalculatePrice();

        public virtual void Add(OrderElement orderElement)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(OrderElement orderElement)
        {
            throw new NotImplementedException();
        }
    }
}
