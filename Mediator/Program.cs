// See https://aka.ms/new-console-template for more information
using Mediator;

Console.WriteLine("Hello, World!");

Component1 Component1 = new();
Component2 Component2 = new();
ConcreteMediator concreteMediator = new ConcreteMediator(Component1, Component2);
Console.WriteLine("Somebody run method A");
Component1.DoA();

Console.WriteLine("Somebody run method C");
Component2.DoC();
