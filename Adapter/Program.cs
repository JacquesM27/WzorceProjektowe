// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("Hello, World!");

ILogSaver logSaver = new SqlLogSaverAdapter();
logSaver.Save(1, "test1");
logSaver.Save(2, "test2");

logSaver = new FileLogSaverAdapter();
logSaver.Save(3, "test3");
logSaver.Save(4, "test4");

logSaver = new EmailLogSaverAdapter();
logSaver.Save(1, "test email");
logSaver.Save(2323, "blah");