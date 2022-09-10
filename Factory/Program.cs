// See https://aka.ms/new-console-template for more information
using Factory;

Console.WriteLine("Hello, World!");

var shipFactory = new ShipFactory();

Console.WriteLine(  shipFactory.DeliverTransport());

var truckFactory = new TruckFactory();

Console.WriteLine( truckFactory.DeliverTransport());
