using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ShipFactory : Factory
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
