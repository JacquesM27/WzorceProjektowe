﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SomeSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("SomeSubject: Hadling request.");
        }
    }
}
