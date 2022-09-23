using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype2
{
    internal abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }
        public Border Border { get; set; }

        public Shape()
        {
        }

        public Shape(Shape shape)
        {
            X = shape.X;
            Y = shape.Y;
            Color = shape.Color;
            Border = shape.Border;
        }

        public abstract Shape Clone();

        public abstract Shape DeepClone();
    }
}
