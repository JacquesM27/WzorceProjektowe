using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class ConcreteStateA : State
    {
        public override void HandleFirstTask()
        {
            Console.WriteLine("ConcreteStateA handles first task");
            Console.WriteLine("ConcreteStateA wants to change the state of context to B");
            _context.TransitionTo(new ConcreteStateB());
        }

        public override void HandleSecondTask()
        {
            Console.WriteLine("ConcreteStateA handles second task");
        }
    }
}
