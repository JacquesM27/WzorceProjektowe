using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge4
{
    internal interface IPhone
    {
        void CallTo(string contact);
        void FindPhone();
        void SetAlarm();
        void CheckWeather();
        void ChangeMusic();
        void VolumeUp();
        void VolumeDown();
    }
}
