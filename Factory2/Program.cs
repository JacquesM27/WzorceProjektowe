// See https://aka.ms/new-console-template for more information
using Factory2;

Console.WriteLine("Hello, Factory!");


Console.WriteLine("Ordered bolt:");
var bf = new BoltFactory();
var bolt = bf.FactoryTransport();
Console.WriteLine(bolt.Deliver());

Console.WriteLine("Ordered uber:");
var uf = new UberFactory();
var uber = uf.FactoryTransport();
Console.WriteLine(uber.Deliver());

Console.WriteLine("Ordered taxi:");
var tf = new TaxiFactory();
var taxi = tf.FactoryTransport();
Console.WriteLine(taxi.Deliver());