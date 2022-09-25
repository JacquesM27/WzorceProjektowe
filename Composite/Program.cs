// See https://aka.ms/new-console-template for more information
using Composite;

Console.WriteLine("Hello, World!");


Product Product = new("toystory dog");
decimal total = Product.CalculatePrice();
Console.WriteLine($"Total order price = {total}");

Carton tree = new("");
Carton branch1 = new("");
branch1.Add(new Product("doll"));
branch1.Add(new Product("doll documentation"));
Carton branch2 = new("");
branch2.Add(new Product("burago car"));
tree.Add(branch1);
tree.Add(branch2);
decimal orderTotal = tree.CalculatePrice();
Console.WriteLine($"Total order price = {orderTotal}");