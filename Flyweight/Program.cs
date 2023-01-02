// See https://aka.ms/new-console-template for more information
using Flyweight;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Flyweight();
        ClassicMethod();
    }

    private static void ClassicMethod()
    {
        List<Tuple<Flyweight.Flyweight, string>> _flyweights = new();
        var random = new Random();
        for (int i = 0; i < 1000000; i++)
        {
            var car = new Car
            {
                Number = random.Next(1, 3).ToString(),//"213",
                Owner = "John",
                Manufacturer = "Audi",
                Model = "A4",
                Color = "Gray"
            };
            _flyweights.Add(new Tuple<Flyweight.Flyweight, string>(new Flyweight.Flyweight(car), GetKey(car)));
        }

        var count = _flyweights.Count;
        Console.WriteLine($"ClassicMethod: I have {count} flyweights:");
        _flyweights.ForEach(flyweight => Console.WriteLine(flyweight.Item2));
    }

    private static string GetKey(Car car)
    {
        List<string> elements = new()
            {
                car.Model,
                car.Color,
                car.Manufacturer
            };
        if (car.Owner is not null)
        {
            elements.Add(car.Owner);
        }
        if (car.Number is not null)
        {
            elements.Add(car.Number);
        }
        elements.Sort();
        Console.WriteLine($"HASH: {string.Join("_", elements)}");
        return string.Join("_", elements);
    }

    private static void Flyweight()
    {
        var factory = new FlyweightFactory(
           new Car { Manufacturer = "Opel", Model = "Insignia", Color = "White" },
           new Car { Manufacturer = "Mercedes Benz", Model = "S500", Color = "Black" },
           new Car { Manufacturer = "BMW", Model = "M4", Color = "Yellow" },
           new Car { Manufacturer = "Audi", Model = "RS7", Color = "Gray" }
           );
        factory.ListFlyweights();
        AddCarToDb(factory, new Car
        {
            Number = "213",
            Owner = "John",
            Manufacturer = "Audi",
            Model = "A4",
            Color = "Silver"
        });
        AddCarToDb(factory, new Car
        {
            Number = "213",
            Owner = "John",
            Manufacturer = "Audi",
            Model = "A4",
            Color = "Gray"
        });
        var random = new Random();
        for(int i = 0; i < 1000000; i++)
        {
            AddCarToDb(factory, new Car
            {
                Number = random.Next(1,3).ToString(),//"213",
                Owner = "John",
                Manufacturer = "Audi",
                Model = "A4",
                Color = "Gray"
            });
        }
        factory.ListFlyweights();
    }

    private static void AddCarToDb(FlyweightFactory factory, Car car)
    {
        Console.WriteLine("Adding car to db");

        var flyweight = factory.GetFlyweight(new Car
        {
            Color = car.Color,
            Manufacturer = car.Manufacturer,
            Model = car.Model,
        });
        flyweight.Operation(car);
    }
}