using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    public interface IMessageSender
    {
        public void SendMessage(string receiver, string title, string body);
    }
}
