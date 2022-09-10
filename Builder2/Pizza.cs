using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    public class Pizza : Dinner
    {
        public override decimal CalculatePrice()
        {
            return 30 + (ingredients.Count * 2);
        }

        public void AddIngredient(string ingredient)
        {
            Console.WriteLine($"Add {ingredient}");
            ingredients.Add(ingredient);
        }
    }
}
