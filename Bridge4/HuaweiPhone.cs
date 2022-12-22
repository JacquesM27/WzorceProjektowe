using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge4
{
    internal class HuaweiPhone : IPhone
    {
        public void CallTo(string contact)
        {
            Console.WriteLine("Huawei call to " + contact);
        }

        public void ChangeMusic()
        {
            Console.WriteLine("Huawei change music");
        }

        public void CheckWeather()
        {
            Console.WriteLine("Huawei check weather");
        }

        public void FindPhone()
        {
            Console.WriteLine("Huawei find phone");
        }

        public void SetAlarm()
        {
            Console.WriteLine("Huawei set alarm");
        }

        public void VolumeDown()
        {
            Console.WriteLine("Huawei volume down");
        }

        public void VolumeUp()
        {
            Console.WriteLine("Huawei volume up");
        }
    }
}
