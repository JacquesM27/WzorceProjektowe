using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class FirstComponent : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitFirstComponent(this);
        }

        public string ExtraMethod()
        {
            return "hi!";
        }
    }
}
