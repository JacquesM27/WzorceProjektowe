using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Factory
    {
        public abstract ITransport CreateTransport();

        public string DeliverTransport()
        {
            var transport = CreateTransport();
            var result = "Factory send your delivery [...]"
                + "\n" + transport.Deliver();

            return result;
        }
    }
}
