// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");

var director = new Director();
var coupeBuilder = new CoupeCarBuilder();
director.CarBuilder = coupeBuilder;

Console.WriteLine("Basic coupe car product:");
var coupeCarBasic = director.BuildBasicCar();
Console.WriteLine(coupeCarBasic.ToString());

Console.WriteLine("\nPremium coupe car product:");
var coupeCarPremium = director.BuildPremiumCar();
Console.WriteLine(coupeCarPremium.ToString());

var wagonBuilder = new WagonCarBuilder();
director.CarBuilder = wagonBuilder;

Console.WriteLine("\nBasic wagon car product:");
var wagonCarBasic = director.BuildBasicCar();
Console.WriteLine(wagonCarBasic.ToString());

Console.WriteLine("\nPremium wagon car product:");
var wagonCarPremium = director.BuildPremiumCar();
Console.WriteLine(wagonCarPremium.ToString());
