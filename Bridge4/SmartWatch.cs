using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge4
{
    internal class SmartWatch
    {
        protected readonly IPhone phone;

        public SmartWatch(IPhone phone)
        {
            this.phone = phone;
        }

        public void CallTo()
        {
            phone.CallTo("sister");
        }

        public void WhereIsMyPhone()
        {
            phone.FindPhone();
        }

        public void CheckWeather()
        {
            phone.CheckWeather();
        }

        public void SetNextTrack()
        {
            phone.ChangeMusic();
        }

        public void TooLoud()
        {
            phone.VolumeDown();
        }

        public void TooQuiet()
        {
            phone.VolumeUp();
        }
    }
}
