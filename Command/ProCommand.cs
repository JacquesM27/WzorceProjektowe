using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ProCommand : ICommand
    {
        private ProComponent _proComponent;
        private string _broadcastMessage;
        public ProCommand(ProComponent proComponent, string broadcastMessage)
        {
            _proComponent = proComponent;
            _broadcastMessage = broadcastMessage;
        }

        public void Execute()
        {
            Console.WriteLine($"Broadcast message: {_broadcastMessage}");
            _proComponent.DoSomethingPro("ProCommand");
            _proComponent.Backflip();
        }
    }
}
