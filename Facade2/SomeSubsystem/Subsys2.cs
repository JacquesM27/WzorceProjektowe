using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade2.SomeSubsystem
{
    internal class SubsSys2
    {
        public SubsSys2()
        {
            Console.WriteLine("Subsystem2 is ready");
        }

        public void OperationX()
        {
            Console.WriteLine("Prepraing rocket launcher...");
        }
    }
}
