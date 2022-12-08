using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter3
{
    internal class SomeExternalSmsSender
    {
        public void SendSms(string receiverPhoneNumber, string textMessage)
        {
            Console.WriteLine($"Sending SMS to:{receiverPhoneNumber}\nwith text:{textMessage}");
        }
    }
}
