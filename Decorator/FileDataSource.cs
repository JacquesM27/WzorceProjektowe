using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class FileDataSource : DataSource
    {
        public override string ReadData()
        {
            return $"Reading file data";
        }

        public override string WriteData()
        {
            return $"Writing file data";
        }
    }
}
