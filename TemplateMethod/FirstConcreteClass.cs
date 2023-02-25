using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class FirstConcreteClass : SomeAbstractClass
    {
        protected override void FirstRequiredOperation()
        {
            Console.WriteLine("FirstConcreteClass: Implementation of FirstRequiredOperation");
        }

        protected override void SecondRequiredOperation()
        {
            Console.WriteLine("FirstConcreteClass: Implementation of SecondRequiredOperation");
        }

        protected override void SecondOptionalHook()
        {
            Console.WriteLine("FirstConcreteClass: Overriding second optional hook");
        }
    }
}
