using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    internal class PizzaDirector
    {
        private IPizzaBuilder _builder;
        public IPizzaBuilder Builder
        {
            set { _builder = value; }
        }

        public void MakeMargherita()
        {
            Console.WriteLine("Preparing margherita...");
            var pizza = _builder.MakeDough()
                .AddCheese()
                .AddTomatoSauce()
                .Build();
            Console.WriteLine("Margherita is ready");
            Console.WriteLine($"Price: {pizza.CalculatePrice()}");
            _builder.Reset();
        }

        public void MakeSalami()
        {
            Console.WriteLine("Preparing salami pizza...");
            var pizza = _builder.MakeDough()
                .AddCheese()
                .AddTomatoSauce()
                .AddSalami()
                .Build();
            Console.WriteLine("Salami is ready");
            Console.WriteLine($"Price: {pizza.CalculatePrice()}");
            _builder.Reset();
        }

        public void MakeAnotherPizza()
        {
            Console.WriteLine("Preparing another pizza...");
            var pizza = _builder.MakeDough()
                .AddCheese()
                .AddCheese()
                .AddTomatoSauce()
                .AddOlives()
                .AddRucola()
                .Build();
            Console.WriteLine("another pizza is ready");
            Console.WriteLine($"Price : {pizza.CalculatePrice()}");
            _builder.Reset();
        }
    }
}
