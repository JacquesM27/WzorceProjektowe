using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Triangle : Shape
    {
        public override Shape DeepClone()
        {
            var triangle = (Shape)MemberwiseClone();
            triangle.Border = new Border
            {
                Color = Border.Color,
                Size = Border.Size
            };
            return triangle;
        }

        public override Shape ShallowClone()
        {
            return (Shape)MemberwiseClone();
        }
    }
}
