using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class FirstVisistor : IVisitor
    {
        public void VisitFirstComponent(FirstComponent component)
        {
            Console.WriteLine(component.ExtraMethod()+" FirstVisistor");
        }

        public void VisitSecondComponent(SecondComponent component)
        {
            Console.WriteLine(component.SomeMethod() + " FirstVisistor");
        }
    }
}
