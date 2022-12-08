using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    public class TransferFromXml
    {
        private readonly BankXmlObject bankXmlObject;
        public TransferFromXml(BankXmlObject bankXmlObject)
        {
            this.bankXmlObject = bankXmlObject;
        }

        public void DoTransfer()
        {
            Console.WriteLine($"Transfer done to: acc Id {bankXmlObject.AccountId}, Name {bankXmlObject.Name}, Value {bankXmlObject.Value}");
        }
    }
}
