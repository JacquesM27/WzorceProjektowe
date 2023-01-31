﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal interface IMemento
    {
        string GetName();
        string GetState();
        DateTime GetDateTime();
    }
}
