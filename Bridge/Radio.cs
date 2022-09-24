using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Radio : IDevice
    {
        private readonly Random random = new();
        public void Disable()
        {
            Console.WriteLine("Radio disabled");
        }

        public void Enable()
        {
            Console.WriteLine("Radio enabled");
        }

        public int GetChannel()
        {
            int result = random.Next(87, 108);
            Console.WriteLine($"Radio get channel - {result}");
            return result;
        }

        public int GetVolume()
        {
            int result = random.Next(0, 100);
            Console.WriteLine($"Radio get volume - {result}");
            return result;
        }

        public bool IsEnabled()
        {
            return true;
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Radio set channel - {channel}");
        }

        public void SetVolume(int percent)
        {
            Console.WriteLine($"Radio set volume - {percent}");
        }
    }
}
