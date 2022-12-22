using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge4
{
    internal class SamsungPhone : IPhone
    {
        public void CallTo(string contact)
        {
            Console.WriteLine("Samsung call to " + contact);
        }

        public void ChangeMusic()
        {
            Console.WriteLine("Samsung change music");
        }

        public void CheckWeather()
        {
            Console.WriteLine("Samsung check weather");
        }

        public void FindPhone()
        {
            Console.WriteLine("Samsung find phone");
        }

        public void SetAlarm()
        {
            Console.WriteLine("Samsung set alarm");
        }

        public void VolumeDown()
        {
            Console.WriteLine("Samsung volume down");
        }

        public void VolumeUp()
        {
            Console.WriteLine("Samsung volume up");
        }
    }
}
