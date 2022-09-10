using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    internal class Taxi : ITransport
    {
        public string Deliver()
        {
            return "Ło panie za tyle to mi się nie opłaca odpalać";
        }
    }
}
