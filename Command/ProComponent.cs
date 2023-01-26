using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ProComponent
    {
        public void DoSomethingPro(string pro)
        {
            Console.WriteLine($"I'm doing pro {pro}");
        }

        public void Backflip()
        {
            Console.WriteLine("PARKOUR!");
        }
    }
}
