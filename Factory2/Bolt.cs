using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    internal class Bolt : ITransport
    {
        public string Deliver()
        {
            return "Hi im Rajesh, get in!";
        }
    }
}
