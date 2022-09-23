// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");

DbManager DbManager1 = DbManager.GetInstance();
DbManager DbManager2 = DbManager.GetInstance();

Console.WriteLine("DbManager1 equals DbManager2?: " + (DbManager1 == DbManager2));

Console.WriteLine("\nThread safe singleton");

Thread process1 = new Thread(() =>
{
    var api = SomeApiManager.GetInstance("process1");
    Console.WriteLine(api.TestObject);
});

Thread process2 = new Thread(() =>
{
    var api = SomeApiManager.GetInstance("process2");
    Console.WriteLine(api.TestObject);
});

process1.Start();
process2.Start();
process1.Join();
process2.Join();