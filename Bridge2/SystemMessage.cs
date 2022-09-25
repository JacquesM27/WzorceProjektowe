using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    internal class SystemMessage : Message
    {
        public SystemMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        public override void Send(string title, string body)
        {
            MessageSender.SendMessage("admin@company.com", title, body);
        }
    }
}
