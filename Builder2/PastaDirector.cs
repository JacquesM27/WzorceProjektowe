using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    internal class PastaDirector
    {
        private IPastaBuilder _builder;
        public IPastaBuilder Builder
        {
            set { _builder = value; }
        }

        public void MakeBolognese()
        {
            Console.WriteLine("Preparing bolognese...");
            var pasta = _builder.BoilPasta()
                .PrepareMeat()
                .MakeTomatoSauce()
                .Build();
            Console.WriteLine("Bolognese is ready");
            Console.WriteLine($"Price: {pasta.CalculatePrice()}");
            _builder.Reset();
        }

        public void MakeCarbonara()
        {
            Console.WriteLine("Preparing carbonara...");
            var pasta = _builder.BoilPasta()
                .MakeCreamSauce()
                .Build();
            Console.WriteLine("Carbonara is ready");
            Console.WriteLine($"Price: {pasta.CalculatePrice()}");
            _builder.Reset();
        }
    }
}
