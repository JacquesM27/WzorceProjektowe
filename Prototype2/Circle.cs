using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype2
{
    internal class Circle : Shape
    {

        public Circle()
        {
        }

        public Circle(Circle circle) : base(circle)
        {
            X = circle.X;
            Y = circle.Y;
            Color = circle.Color;
            Border = circle.Border;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }

        public override Shape DeepClone()
        {
            var circle = new Circle(this)
            {
                Border = new Border
                {
                    Size = Border.Size
                }
            };
            return circle;
        }

        public override string ToString()
        {
            return $"X={X}, Y={Y}, Color={Color}, Border={Border.Size}";
        }
    }
}
