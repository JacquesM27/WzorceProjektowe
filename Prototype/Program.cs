// See https://aka.ms/new-console-template for more information
using Prototype;

Console.WriteLine("Hello, World!");


Rectangle rectangle1 = new()
{
    X = 1,
    Y = 2,
    Border = new Border
    {
        Color = "Red",
        Size = "10px",
    }
};

Rectangle rectangle2 = (Rectangle)rectangle1.ShallowClone();

Rectangle rectangle3 = (Rectangle)rectangle1.DeepClone();


Console.WriteLine("Rectangle 1\n" + rectangle1.ToString());
Console.WriteLine("Rectangle 2 shallow\n" + rectangle2.ToString());
Console.WriteLine("Rectangle 3 deep\n" + rectangle3.ToString());

rectangle1.X = 20;
rectangle1.Y = 3;
rectangle1.Border.Color = "Yellow";

Console.WriteLine("Rectangle 1\n" + rectangle1.ToString());
Console.WriteLine("Rectangle 2 shallow\n" + rectangle2.ToString());
Console.WriteLine("Rectangle 3 deep\n" + rectangle3.ToString());
