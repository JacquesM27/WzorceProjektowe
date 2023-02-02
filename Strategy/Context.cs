using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy) => _strategy = strategy;

        public Context()
        {
        }

        public void SetStrategy(IStrategy strategy) => _strategy = strategy;

        public void SomeComplicatedBusinessLogic(string data)
        {
            Console.WriteLine("Context: Sorting data using the strategy:");
            IEnumerable<string> result = _strategy.DoComplicatedAlgorithm(data);
            foreach (var item in result)
            {
                Console.Write($"{item},");
            }
            Console.WriteLine();
        }
    }
}
