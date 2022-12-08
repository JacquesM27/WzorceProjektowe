using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter3
{
    internal class SmsSenderAdapter : INotificationSender
    {
        private readonly SomeExternalSmsSender ExternalSmsSender;
        public string PhoneNumber { get; set; }
        public string Text { get; set; }
        public SmsSenderAdapter()
        {
            ExternalSmsSender = new();
        }

        public void SendNotification()
        {
            ExternalSmsSender.SendSms(PhoneNumber, Text);
        }
    }
}
