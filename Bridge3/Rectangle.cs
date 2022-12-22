using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge3
{
    internal class Rectangle : BaseShape
    {
        public Rectangle(IPaint paint) : base(paint)
        {
        }
    }
}
