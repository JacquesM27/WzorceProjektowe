using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class SecondVisitor : IVisitor
    {
        public void VisitFirstComponent(FirstComponent component)
        {
            Console.WriteLine(component.ExtraMethod() + " SecondVisitor");
        }

        public void VisitSecondComponent(SecondComponent component)
        {
            Console.WriteLine(component.SomeMethod() + " SecondVisitor");
        }
    }
}
