using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class TruckFactory : Factory
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
