using Facade2.SomeSubsystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade2
{
    internal class SomeSubsystemFacade
    {
        private readonly SubSys1 subSys1;
        private readonly SubsSys2 subSys2;

        public SomeSubsystemFacade()
        {
            Console.WriteLine("Initializing subsystems");
            subSys1 = new SubSys1();
            subSys2 = new SubsSys2();
        }

        public void Operation()
        {
            Console.WriteLine("Perform subsystems actions");
            subSys1.DoYourJob();
            subSys2.OperationX();
            Console.WriteLine("finito");
        }
    }
}
