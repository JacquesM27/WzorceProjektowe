// See https://aka.ms/new-console-template for more information
using Proxy;

Console.WriteLine("Hello, World!");

Client client= new();

Console.WriteLine("Client without using a proxy");
SomeSubject someSubject= new();
client.DoRequest(someSubject);

Console.WriteLine("Client with using a proxy");
ProxySubject proxySubject = new(someSubject);
client.DoRequest(proxySubject);