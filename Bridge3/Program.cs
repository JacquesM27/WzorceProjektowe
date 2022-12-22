// See https://aka.ms/new-console-template for more information
using Bridge3;

Console.WriteLine("Hello, World!");


RedPaint redPaint = new();
BluePaint bluePaint = new();

Rectangle rectangle = new(redPaint);
Console.WriteLine(rectangle.ToString());
rectangle.Paint = bluePaint;
Console.WriteLine(rectangle.ToString());

Triangle triangle = new(redPaint);
Console.WriteLine(triangle.ToString());
triangle.Paint = bluePaint;
Console.WriteLine(triangle.ToString());