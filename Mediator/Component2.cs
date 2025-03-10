﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Component2 : BaseComponent
    {
        public void DoC()
        {
            Console.WriteLine("Component2 does C.");
            _mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("Component2 does D.");
            _mediator.Notify(this, "D");
        }
    }
}
