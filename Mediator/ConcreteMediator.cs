using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class ConcreteMediator : IMediator
    {
        private Component1 _component;
        private Component2 _component2;
        public ConcreteMediator(Component1 component, Component2 component2)
        {
            _component = component;
            _component.SetMediator(this);
            _component2 = component2;
            _component2.SetMediator(this);
        }

        public void Notify(object sender, string message)
        {
            if (message == "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers following methods:");
                _component.DoB();
            }
            else if (message == "C") 
            {
                Console.WriteLine("Mediator reacts on C and triggers following methods:");
                _component.DoB();
                _component2.DoD();
            }
        }
    }
}
