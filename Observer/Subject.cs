using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Subject : ISubject
    {
        public int State { get; set; } = 0;
        private List<IObserver> _observers = new();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached on observer.");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("Subject: Detached an observer.");
            _observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notyfying observers");
            _observers.ForEach(c => c.Update(this));
        }

        public void BusinessLogic()
        {
            Console.WriteLine("Subject: Doing important business logic.");
            State = new Random().Next(0, 8);
            Console.WriteLine("Subject: My state has changed to: " + State.ToString());
            Notify();
        }
    }
}
