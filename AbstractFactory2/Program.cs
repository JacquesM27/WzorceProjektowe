// See https://aka.ms/new-console-template for more information
using AbstractFactory2;

Console.WriteLine("Hello, World!");

var sapFactory = new SapFactory();

var WaproFactory = new WaproFactory();

Client Client = new ();

Console.WriteLine("wapro");
Client.DoProcess(WaproFactory);

Console.WriteLine("sap");
Client.DoProcess(sapFactory);