using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(DataSource wrappee) : base(wrappee)
        {
        }

        public override string ReadData()
        {
            return "COMPRESSED " + base.ReadData();
        }

        public override string WriteData()
        {
            return "DECOMPRESSED " + base.WriteData();
        }
    }
}
