using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Rectangle : Shape
    {
        public override Shape DeepClone()
        {
            var clone = (Rectangle)MemberwiseClone();
            clone.Border = new Border
            {
                Color = Border.Color,
                Size = Border.Size
            };
            return clone;
        }

        public override Shape ShallowClone()
        {
            return (Rectangle)MemberwiseClone();
        }
    }
}
