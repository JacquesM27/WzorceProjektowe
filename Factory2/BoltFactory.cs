﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    internal class BoltFactory : Factory
    {
        public override ITransport FactoryTransport()
        {
            return new Bolt();
        }
    }
}
