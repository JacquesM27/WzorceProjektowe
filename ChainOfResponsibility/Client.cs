using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Client
    {
        public static void DoSomeWork(AbstractHandler abstractHandler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee", "MeatBall" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = abstractHandler.Handle(food);

                if(result != null)
                {
                    Console.WriteLine($"{result}.");
                }
                else
                {
                    Console.WriteLine($"{food} was left untouched.");
                }
            }
        }
    }
}
