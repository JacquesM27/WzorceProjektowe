using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command) => _command = command;

        public void DoSomething()
        {
            Console.WriteLine("Invoker invoke command job:");
            _command.Execute();
            Console.WriteLine("That's all folks");
        }
    }
}
