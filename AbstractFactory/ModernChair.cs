using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ModernChair : IChair
    {
        public string SitHere()
        {
            return "Maybe it's not comfortable but it's expensive";
        }
    }
}
