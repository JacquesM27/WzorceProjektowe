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

Console.WriteLine($"Circle1 X={circle1.X}, Y={circle1.Y}, Color={circle1.Color}, Border={circle1.Border.Size}");
Console.WriteLine($"Circle2 X={circle2.X}, Y={circle2.Y}, Color={circle2.Color}, Border={circle2.Border.Size}");
Console.WriteLine($"Circle3 X={circle3.X}, Y={circle3.Y}, Color={circle3.Color}, Border={circle3.Border.Size}");
Console.WriteLine("\n");
circle1.X = 0;
circle1.Color = "Black";
circle1.Border.Size = "1rem";

Console.WriteLine($"Circle1 X={circle1.X}, Y={circle1.Y}, Color={circle1.Color}, Border={circle1.Border.Size}");
Console.WriteLine($"Circle2 X={circle2.X}, Y={circle2.Y}, Color={circle2.Color}, Border={circle2.Border.Size}");
Console.WriteLine($"Circle3 X={circle3.X}, Y={circle3.Y}, Color={circle3.Color}, Border={circle3.Border.Size}");
