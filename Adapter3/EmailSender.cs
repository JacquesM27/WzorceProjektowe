using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter3
{
    internal class EmailSender : INotificationSender
    {
        public string RecipientEmail { get; set; }
        public string SubjectEmail { get; set; }
        public string Content { get; set; }

        public void SendNotification()
        {
            Console.WriteLine($"Send email to:{RecipientEmail}\nTopic:{SubjectEmail}\nContent:{Content}");
        }
    }
}
