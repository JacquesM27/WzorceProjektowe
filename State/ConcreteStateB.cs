using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class ConcreteStateB : State
    {
        public override void HandleFirstTask()
        {
            Console.WriteLine("ConcreteStateB handles first task");
        }

        public override void HandleSecondTask()
        {
            Console.WriteLine("ConcreteStateB handles second task");
            Console.WriteLine("ConcreteStateB wants to change the state of context");
            _context.TransitionTo(new ConcreteStateA());
        }
    }
}
