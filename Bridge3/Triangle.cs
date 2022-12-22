using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge3
{
    internal class Triangle : BaseShape
    {
        public Triangle(IPaint paint) : base(paint)
        {
        }
    }
}
