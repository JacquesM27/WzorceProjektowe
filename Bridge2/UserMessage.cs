using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    internal class UserMessage : Message
    {
        public string UserDescription { get; set; }
        public UserMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        public override void Send(string title, string body)
        {
            MessageSender.SendMessage("user@company.com",title,body+$"\nUser description:{UserDescription}");
        }
    }
}
