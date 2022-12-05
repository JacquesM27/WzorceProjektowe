// See https://aka.ms/new-console-template for more information
using Builder3;

Console.WriteLine("Hello, World!");

HomeBuilder builder = new();
ConstructionManager constructionManager = new(builder);
//constructionManager.Builder = builder;
var groundfloorHouse = constructionManager.BuildGroundfloorHouse();
var twoFloorApartmentWithSwimmingPool = constructionManager.BuildTwoFloorApartmentWithSwimmingPool();
var homeInForest = constructionManager.BuildHomeInForest();