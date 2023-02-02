// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, World!");


Context Context = new();

string testingData = "cdfeganzi";
Console.WriteLine($"testing data: {testingData}");

Console.WriteLine("Client: Strategy is set to first strategy");
Context.SetStrategy(new FirstConcreteStrategy());
Context.SomeComplicatedBusinessLogic(testingData);

Console.WriteLine("Client: Strategy is set to second strategy");
Context.SetStrategy(new SecondConcreteStrategy());
Context.SomeComplicatedBusinessLogic(testingData);

testingData = "abcddezaf";
Console.WriteLine("Client: Strategy is set to first strategy");
Context.SetStrategy(new FirstConcreteStrategy());
Context.SomeComplicatedBusinessLogic(testingData);

Console.WriteLine("Client: Strategy is set to second strategy");
Context.SetStrategy(new SecondConcreteStrategy());
Context.SomeComplicatedBusinessLogic(testingData);