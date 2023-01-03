using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxySubject : ISubject
    {
        private SomeSubject _subject;
        public ProxySubject(SomeSubject subject)
        {
            _subject = subject;
        }

        public void Request()
        {
            if (CheckCredentials())
            {
                _subject.Request();
                LogAccess();
            }
        }

        private bool CheckCredentials()
        {
            Console.WriteLine("ProxySubject: Checking credentials... Get in!");
            return true;
        }

        private void LogAccess()
        {
            Console.WriteLine("ProxySubject: Logging time of request");
        }
    }
}
