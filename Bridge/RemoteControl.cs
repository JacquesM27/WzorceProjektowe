using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RemoteControl
    {
        private readonly IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            Console.WriteLine("*power button click*");
            if (device.IsEnabled())
            {
                device.Disable();
            }
            else
            {
                device.Enable();
            }
        }

        public void VolumeUp()
        {
            Console.WriteLine("*volume up click*");
            device.SetVolume(device.GetVolume() + 1);
        }

        public void VolumeDown()
        {
            Console.WriteLine("*volume down click*");
            device.SetVolume(device.GetVolume() - 1);
        }

        public void ChannelUp()
        {
            Console.WriteLine("*channel up click*");
            device.SetChannel(device.GetChannel() + 1);
        }

        public void ChannelDown()
        {
            Console.WriteLine("*channel down click*");
            device.SetChannel(device.GetChannel() - 1);
        }
    }
}
