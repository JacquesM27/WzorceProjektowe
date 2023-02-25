using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class SecondComponent : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitSecondComponent(this);
        }

        public string SomeMethod()
        {
            return "bye";
        }
    }
}
