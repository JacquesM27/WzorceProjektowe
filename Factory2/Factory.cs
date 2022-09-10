using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    internal abstract class Factory
    {
        public abstract ITransport FactoryTransport();
    }
}
