using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Context
    {
        private State _state = null;

        public Context(State state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine("Context: Transition to: " + state.GetType().Name);
            _state = state;
            state.SetContext(this);
        }

        public void FirstRequest() => _state.HandleFirstTask();

        public void SecondRequest() => _state.HandleSecondTask();
    }
}
