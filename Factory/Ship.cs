﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Ship : ITransport
    {
        public string Deliver()
        {
            return "Delivered by Ship";
        }
    }
}
