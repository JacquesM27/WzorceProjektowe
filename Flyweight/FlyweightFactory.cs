using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> _flyweights = new();

        public FlyweightFactory(params Car[] args)
        {
            foreach (var car in args)
            {
                _flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(car), GetKey(car)));
            }
        }

        private string GetKey(Car car)
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
            if(car.Number is not null)
            {
                elements.Add(car.Number);
            }
            elements.Sort();
            Console.WriteLine($"HASH: {string.Join("_", elements)}");
            return string.Join("_", elements);
        }

        internal Flyweight GetFlyweight(Car sharedState)
        {
            string key = GetKey(sharedState);

            if (!_flyweights.Where(t => t.Item2 == key).Any())
            {
                Console.WriteLine($"FlyweightFactory: Can't find a flyweight, creating new one.");
                _flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), GetKey(sharedState)));
            }
            else
            {
                Console.WriteLine($"FlyweightFactory: Reusing existing flyweight.");
            }
            return _flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }

        public void ListFlyweights()
        {
            var count = _flyweights.Count;
            Console.WriteLine($"FlyweightFactory: I have {count} flyweights:");
            _flyweights.ForEach(flyweight => Console.WriteLine(flyweight.Item2));
        }
    }
}
