using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class SecondConcreteClass : SomeAbstractClass
    {
        protected override void FirstRequiredOperation()
        {
            Console.WriteLine("SecondConcreteClass: Implementation of FirstRequiredOperation");
        }

        protected override void SecondRequiredOperation()
        {
            Console.WriteLine("SecondConcreteClass: Implementation of SecondRequiredOperation");
        }

        protected override void FirstOptionalHook()
        {
            Console.WriteLine("SecondConcreteClass: Overriding of first hook");
        }

        protected override void SecondOptionalHook()
        {
            Console.WriteLine("SecondConcreteClass: Overriding of second hook");
        }
    }
}
