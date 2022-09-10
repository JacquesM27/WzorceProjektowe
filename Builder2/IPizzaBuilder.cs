using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    public interface IPizzaBuilder
    {
        IPizzaBuilder MakeDough();
        IPizzaBuilder AddTomatoSauce();
        IPizzaBuilder AddCheese();
        IPizzaBuilder AddSalami();
        IPizzaBuilder AddOlives();
        IPizzaBuilder AddParmaHam();
        IPizzaBuilder AddRucola();
        IDinner Build();
        void Reset();
    }
}
