using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class PremiumRemoteControl : RemoteControl
    {
        private readonly IDevice device;
        public PremiumRemoteControl(IDevice device) : base(device)
        {
            this.device = device;
        }

        public void Mute()
        {
            device.SetVolume(0);
        }

        public void TogglePremiumPower()
        {
            Console.WriteLine("*golden power button click*");
            if (device.IsEnabled())
            {
                device.Disable();
            }
            else
            {
                device.Enable();
            }
        }
    }
}
