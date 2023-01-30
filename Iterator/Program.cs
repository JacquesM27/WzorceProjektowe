// See https://aka.ms/new-console-template for more information
using Iterator;

Console.WriteLine("Hello, World!");

WordsCollection collection = new();
collection.AddItem("First");
collection.AddItem("Second");
collection.AddItem("Third");
collection.AddItem("Test");

Console.WriteLine("Straight iteration");

foreach (var item in collection)
{
    Console.WriteLine(item);
}

Console.WriteLine("Reverse direction");
collection.ReverseDirection();

foreach (var item in collection)
{
    Console.WriteLine(item);
}