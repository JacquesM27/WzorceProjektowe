// See https://aka.ms/new-console-template for more information
using Observer;

Console.WriteLine("Hello, World!");


Subject subject = new();//publisher
FirstConcreteObserver firstObserver = new();
SecondConcreteObserver secondObserver = new();

subject.Attach(firstObserver);
subject.Attach(secondObserver);

subject.BusinessLogic();
subject.BusinessLogic();
subject.BusinessLogic();

subject.Detach(secondObserver);

subject.BusinessLogic();