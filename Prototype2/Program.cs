// See https://aka.ms/new-console-template for more information
using Prototype2;

Console.WriteLine("Hello, World!");


Circle circle1 = new()
{
    X = 11,
    Y = 12,
    Color = "White",
    Border = new Border()
    {
        Size = "10px"
    }
};

Circle circle2 = (Circle)circle1.Clone();
Circle circle3 = (Circle)circle1.DeepClone();

Console.WriteLine("Circle1 " + circle1.ToString());
Console.WriteLine("Circle2 " + circle2.ToString());
Console.WriteLine("Circle3 " + circle3.ToString());
Console.WriteLine("\n");

circle1.X = 0;
circle1.Color = "Black";
circle1.Border.Size = "1rem";
Console.WriteLine("Circle1 " + circle1.ToString());
Console.WriteLine("Circle2 " + circle2.ToString());
Console.WriteLine("Circle3 " + circle3.ToString());
Console.WriteLine("\n");

Shape shape = circle2.Clone();
shape.Border.Size = "99999rem";
shape.Y = 99;
Console.WriteLine("Circle1 " + circle1.ToString());
Console.WriteLine("Circle2 " + circle2.ToString());
Console.WriteLine("Circle3 " + circle3.ToString());
Console.WriteLine("shape " + shape.ToString());
