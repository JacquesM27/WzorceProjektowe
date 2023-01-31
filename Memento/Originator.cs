using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Originator
    {
        private string _state;
        public Originator(string state)
        {
            _state = state;
            Console.WriteLine("Originator: Initial state: " + _state);
        }

        public void DoSomething()
        {
            Console.WriteLine("Originator: I'm doing something important.");
            _state = GenerateRandomString(30);
            Console.WriteLine("Originator: new state! "+_state);
        }

        public IMemento Save()
        {
            return new ConcreteMemento(_state);
        }

        public void Restore(IMemento memento)
        {
            if(memento is not ConcreteMemento)
            {
                throw new Exception("Unknow memento class " + memento.ToString());
            }
            _state = memento.GetState();
            Console.WriteLine("Originator: state restored: " + _state);
        }

        private string GenerateRandomString(int length)
        {
            Thread.Sleep(1000);
            var random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[length];
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return new string(stringChars);
        }
    }
}
