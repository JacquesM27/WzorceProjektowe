// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

Console.WriteLine("Hello, World!");

var monkey = new MonkeyHandler();
var squirrel = new SquirrelHandler();
var dog = new DogHandler();

monkey.SetNext(squirrel).SetNext(dog);

Console.WriteLine("Chain: Monkey > Squirrel > Dog");
Client.DoSomeWork(monkey);
Console.WriteLine("Subchain Squirrel > Dog");
Client.DoSomeWork(squirrel);

//Console.WriteLine("Some bad idea");
//dog.SetNext(monkey);
//Client.DoSomeWork(monkey);
