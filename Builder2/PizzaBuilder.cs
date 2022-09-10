using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    internal class PizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza = new();
        public IPizzaBuilder AddCheese()
        {
            pizza.AddIngredient("Cheese");
            return this;
        }

        public IPizzaBuilder AddOlives()
        {
            pizza.AddIngredient("Olives");
            return this;
        }

        public IPizzaBuilder AddParmaHam()
        {
            pizza.AddIngredient("ParmaHam");
            return this;
        }

        public IPizzaBuilder AddRucola()
        {
            pizza.AddIngredient("Rucola");
            return this;
        }

        public IPizzaBuilder AddSalami()
        {
            pizza.AddIngredient("Salami");
            return this;
        }

        public IPizzaBuilder AddTomatoSauce()
        {
            pizza.AddIngredient("Tomato sauce");
            return this;
        }

        public IDinner Build()
        {
            return pizza;
        }

        public IPizzaBuilder MakeDough()
        {
            Console.WriteLine("*Impressive spinning of the dough in the air*");
            return this;
        }

        public void Reset()
        {
            pizza = new();
        }
    }
}
