using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class SecondConcreteObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            var parsedSubject = subject as Subject;
            if (parsedSubject.State == 0 || parsedSubject.State >= 2)
            {
                Console.WriteLine("SecondConcreteObserver: Reacted to event! State: "+ parsedSubject.State.ToString());
            }
        }
    }
}
