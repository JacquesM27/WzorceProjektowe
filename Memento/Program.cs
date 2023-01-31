// See https://aka.ms/new-console-template for more information
using Memento;

Console.WriteLine("Hello, World!");

Originator originator = new("Stable as a rock!");
Caretaker caretaker = new(originator);

caretaker.Backup();
originator.DoSomething();
caretaker.Backup();
originator.DoSomething();
caretaker.Backup();
originator.DoSomething();
caretaker.Backup();
originator.DoSomething();
caretaker.Backup();
originator.DoSomething();
Console.WriteLine();
caretaker.ShowHistory();

Console.WriteLine("Client: I need rollback! NOW!");
caretaker.Undo();

Console.WriteLine("Client: Again!");
caretaker.Undo();

Console.WriteLine("Check history again...");
caretaker.ShowHistory();