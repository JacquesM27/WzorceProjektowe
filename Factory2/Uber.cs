using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    internal class Uber : ITransport
    {
        public string Deliver()
        {
            return "Your uber is comming...";
        }
    }
}
