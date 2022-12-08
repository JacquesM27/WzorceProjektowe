using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    internal class BankXmlObjectAdapter : JsonObject
    {
        public BankXmlObjectAdapter(BankXmlObject bankXmlObject)
        {
            AccountId = bankXmlObject.AccountId;
            Value = bankXmlObject.Value;
            Name = bankXmlObject.Name;
        }
    }
}
