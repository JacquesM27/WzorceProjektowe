using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade2.SomeSubsystem
{
    internal class SubSys1
    {
        public SubSys1()
        {
            Console.WriteLine("Subsustem1 ready");
        }
        public void DoYourJob()
        {
            Console.WriteLine("Subsystem doing his job...");
        }
    }
}
