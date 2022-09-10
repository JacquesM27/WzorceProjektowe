using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    internal class PastaBuilder : IPastaBuilder
    {
        private Pasta pasta = new();
        public IPastaBuilder BoilPasta()
        {
            Console.WriteLine("Pasta is boiled");
            return this;
        }

        public IDinner Build()
        {
            return pasta;
        }

        public IPastaBuilder MakeCreamSauce()
        {
            Console.WriteLine("Making cream sauce for carbonara...");
            return this;
        }

        public IPastaBuilder MakeTomatoSauce()
        {
            Console.WriteLine("Making tomato sauce for bolognese...");
            return this;
        }

        public IPastaBuilder PrepareMeat()
        {
            Console.WriteLine("Frying meat");
            return this;
        }

        public void Reset()
        {
            pasta = new();
        }
    }
}
