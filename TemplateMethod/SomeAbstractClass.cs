using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class SomeAbstractClass
    {
        public void TemplateMethod()
        {
            FirstBaseOperation();
            FirstRequiredOperation();
            FirstOptionalHook();
            SecondBaseOperation();
            SecondRequiredOperation();
            ThirdBaseOperation();
            SecondOptionalHook();
        }

        protected void FirstBaseOperation() => Console.WriteLine("SomeAbstractClass: I'm doing FistBaseOperation");

        protected void SecondBaseOperation() => Console.WriteLine("SomeAbstractClass: I'm doing SecondBaseOperation");

        protected void ThirdBaseOperation() => Console.WriteLine("SomeAbstractClass: I'm doing ThirdBaseOperation");

        protected abstract void FirstRequiredOperation();
        protected abstract void SecondRequiredOperation();

        protected virtual void FirstOptionalHook() { }
        protected virtual void SecondOptionalHook() { }
    }
}
