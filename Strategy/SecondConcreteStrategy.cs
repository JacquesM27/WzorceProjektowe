using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SecondConcreteStrategy : IStrategy
    {
        public IEnumerable<string> DoComplicatedAlgorithm(string data)
        {
            var ienumerableData = data.ToCharArray();
            Array.Sort(ienumerableData);
            Array.Reverse(ienumerableData);
            return ienumerableData.Select(c => c.ToString()).AsEnumerable();
        }
    }
}
