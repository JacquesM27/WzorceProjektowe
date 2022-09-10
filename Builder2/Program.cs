// See https://aka.ms/new-console-template for more information
using Builder2;

Console.WriteLine("Hello, World!");

var pastaDirector = new PastaDirector();
var pastaBuilder = new PastaBuilder();
pastaDirector.Builder = pastaBuilder;

pastaDirector.MakeBolognese();
pastaDirector.MakeCarbonara();

var pizzaDirector = new PizzaDirector();
var pizzaBuilder = new PizzaBuilder();
pizzaDirector.Builder = pizzaBuilder;

pizzaDirector.MakeMargherita();
pizzaDirector.MakeSalami();
pizzaDirector.MakeAnotherPizza();