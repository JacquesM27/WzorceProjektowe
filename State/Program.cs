// See https://aka.ms/new-console-template for more information
using State;

Console.WriteLine("Hello, World!");


var context = new Context(new ConcreteStateA());
context.SecondRequest();
context.FirstRequest();
context.FirstRequest();
context.SecondRequest();