﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility2
{
    internal interface IHandler
    {
        void Handle(RequestContext requestContext);
    }
}
