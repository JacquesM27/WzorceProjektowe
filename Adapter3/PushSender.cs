using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter3
{
    internal class PushSender : INotificationSender
    {
        public string AppName { get; set; }
        public string Content { get; set; }

        public void SendNotification()
        {
            Console.WriteLine($"Send push from:{AppName}\nContent:{Content}");
        }
    }
}
