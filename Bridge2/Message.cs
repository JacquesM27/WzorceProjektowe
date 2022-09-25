using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    public abstract class Message
    {
        public IMessageSender MessageSender { get; set; }

        public Message(IMessageSender messageSender)
        {
            MessageSender = messageSender;
        }

        public abstract void Send(string title, string body);
    }
}
