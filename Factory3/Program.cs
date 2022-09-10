// See https://aka.ms/new-console-template for more information
using Factory3;

Console.WriteLine("Hello, World!");


var chef = new DinnerFactory();

Console.WriteLine("Ordered pizza");
var pizza = chef.CreateDinner(DinnerType.Pizza);
Console.WriteLine("Ingredients " + pizza.Ingredients());

Console.WriteLine("Ordered pasta");
var pasta = chef.CreateDinner(DinnerType.Pasta);
Console.WriteLine("Ingredients " + pasta.Ingredients());

Console.WriteLine("Ordered lasagne");
var lasagne = chef.CreateDinner(DinnerType.Lasagne);
Console.WriteLine("Ingredients " + lasagne.Ingredients());