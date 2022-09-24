using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Tv : IDevice
    {
        private readonly Random random = new();
        public void Disable()
        {
            Console.WriteLine("Tv disabled");
        }

        public void Enable()
        {
            Console.WriteLine("Tv enabled");
        }

        public int GetChannel()
        {
            int result = random.Next(1, 30);
            Console.WriteLine($"Tv get channel - {result}");
            return result;
        }

        public int GetVolume()
        {
            int result = random.Next(0, 100);
            Console.WriteLine($"Tv get volume - {result}");
            return result;
        }

        public bool IsEnabled()
        {
            return false;
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Tv set channel - {channel}");
        }

        public void SetVolume(int percent)
        {
            Console.WriteLine($"Tv set volume - {percent}");
        }
    }
}
