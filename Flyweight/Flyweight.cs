using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
        {
            _sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string sharedJson = JsonConvert.SerializeObject(_sharedState, Formatting.Indented);
            string uniqueJson = JsonConvert.SerializeObject(uniqueState, Formatting.Indented);
            Console.WriteLine($"Flyweight: Displaying shared {sharedJson} and unique state {uniqueJson}");
        }
    }
}
