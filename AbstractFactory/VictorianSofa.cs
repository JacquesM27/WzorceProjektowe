﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class VictorianSofa : ISofa
    {
        public string LieDownHere()
        {
            return "This victorian sofa is ok";
        }
    }
}
