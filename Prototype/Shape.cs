using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Border Border { get; set; }

        public abstract Shape ShallowClone();
        public abstract Shape DeepClone();

        public override string ToString()
        {
            return $"X={X}, Y={Y}, Border: Color={Border.Color}, Size={Border.Size}";
        }
    }
}
