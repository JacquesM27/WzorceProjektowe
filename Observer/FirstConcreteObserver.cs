using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class FirstConcreteObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            var subjectParsed = subject as Subject;
            if (subjectParsed.State < 3)
            {
                Console.WriteLine("FirstConcreteObserver: Reacted to Event! State:"+subjectParsed.State.ToString());
            }
        }
    }
}
