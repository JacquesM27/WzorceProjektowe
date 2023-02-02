using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class FirstConcreteStrategy : IStrategy
    {
        public IEnumerable<string> DoComplicatedAlgorithm(string data)
        {
            var ienumerableData = data.ToCharArray();
            Array.Sort(ienumerableData);
            return ienumerableData.Select(c => c.ToString()).AsEnumerable();
        }
    }
}
