// See https://aka.ms/new-console-template for more information
using Command;

Console.WriteLine("Hello, World!");


Invoker invoker = new Invoker();
invoker.SetCommand(new SimpleCommand("Jameson"));
invoker.DoSomething();
invoker.SetCommand(new ProCommand(new ProComponent(), "Hi, I'm Barbra"));
invoker.DoSomething();