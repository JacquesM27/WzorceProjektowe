using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class EncryptorDecorator : DataSourceDecorator
    {
        public EncryptorDecorator(DataSource dataSource) : base(dataSource)
        {
        }

        public override string ReadData()
        {
            return "Decrypted " + base.ReadData();
        }
        public override string WriteData()
        {
            return "Encrypted " + base.WriteData();
        }
    }
}
