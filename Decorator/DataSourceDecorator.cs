using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class DataSourceDecorator : DataSource
    {
        protected DataSource wrappee;

        public DataSourceDecorator(DataSource wrappee)
        {
            this.wrappee = wrappee;
        }


        public override string ReadData()
        {
            return wrappee.ReadData();
        }


        public override string WriteData()
        {
            return wrappee.WriteData();
        }
    }
}
