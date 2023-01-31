using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class ConcreteMemento : IMemento
    {
        private readonly string _state;
        private readonly DateTime _dateTime;

        public ConcreteMemento(string state)
        {
            _state = state;
            _dateTime = DateTime.Now;
        }

        public DateTime GetDateTime() => _dateTime;

        public string GetName() => $"{_dateTime} / {_state[..9]}";

        public string GetState() => _state;
    }
}
