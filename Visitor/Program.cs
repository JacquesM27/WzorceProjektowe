// See https://aka.ms/new-console-template for more information


using Visitor;

Console.WriteLine("Hello, World!");

List<IComponent> components = new()
{
    new FirstComponent(),
    new SecondComponent()
};
Console.WriteLine("The client code works with visitors through first visitor");
var visitor = new FirstVisistor();
Client.ClientCode(components, visitor);

Console.WriteLine("\nAnd the same code works with another visitor");
var secondVisitor = new SecondVisitor();
Client.ClientCode(components, secondVisitor);