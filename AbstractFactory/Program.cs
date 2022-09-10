// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");

var mff = new ModernFurnitureFactory();

Console.WriteLine("Make modern sofa");
var msofa = mff.CreateSofa();
Console.WriteLine(msofa.LieDownHere());

Console.WriteLine("Make modern chair");
var mchair = mff.CreateChair();
Console.WriteLine(mchair.SitHere());

var vff = new VictorianFurnitureFactory();

Console.WriteLine("Make victorian table");
var vtable = vff.CreateTable();
Console.WriteLine(vtable.PutCoffeHere());

Console.WriteLine("Make victorian sofa");
var vsofa = vff.CreateSofa();
Console.WriteLine(vsofa.LieDownHere());

Console.WriteLine("Make party on victorian table");
Console.WriteLine(vtable.PartyTime(msofa,mchair));;

Console.WriteLine("Make modern table");
var mtable = mff.CreateTable();
Console.WriteLine(mtable.PutCoffeHere());

Console.WriteLine("modern party time");
Console.WriteLine(mtable.PartyTime(vsofa,mchair));