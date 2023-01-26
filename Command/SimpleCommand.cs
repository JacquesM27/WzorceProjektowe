using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class SimpleCommand : ICommand
    {
        private string _payload;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"I'm simple printer! BRRR: {{{_payload}}}");
        }
    }
}
