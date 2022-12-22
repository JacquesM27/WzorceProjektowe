using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class DataSource
    {
        public abstract string WriteData();
        public abstract string ReadData();
    }
}
