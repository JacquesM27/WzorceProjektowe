using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Component1 : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Component1 does A.");
            _mediator.Notify(this, "A");
        }
        public void DoB()
        {
            Console.WriteLine("Component1 does B.");
            _mediator.Notify(this, "B");
        }
    }
}
