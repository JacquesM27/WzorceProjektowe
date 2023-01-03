using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Client
    {
        public void DoRequest(ISubject subject)
        {
            subject.Request();
        }
    }
}
