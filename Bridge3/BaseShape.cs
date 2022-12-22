using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge3
{
    abstract class BaseShape
    {
        public IPaint Paint { get; set; }
        public BaseShape(IPaint paint)
        {
            Paint = paint;
        }
        public override string ToString()
        {
            return Paint.Color() + " " + GetType().Name;
        }
    }
}
