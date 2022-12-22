using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge4
{
    internal class SamsungWatch : SmartWatch
    {
        private readonly Random random = new();
        public SamsungWatch(IPhone phone) : base(phone)
        {
        }

        public void CheckStatus()
        {
            Console.WriteLine("Samsung watch checking status");
            phone.FindPhone();
            int result = random.Next(0, 100);
            Console.WriteLine("Samsung watch check battery: " + result);
        }
    }
}
