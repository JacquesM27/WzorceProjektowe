using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    internal class MSMQSender : IMessageSender
    {
        public void SendMessage(string receiver, string title, string body)
        {
            Console.WriteLine($"Microsoft Message Queuing to:\"{receiver}\", title:\"{title}\", body:\"{body}\"");
        }
    }
}
