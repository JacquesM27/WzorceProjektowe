using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    abstract class Iterator : IEnumerator
    {
        public object Current => CurrentObject();

        public abstract int Key();
        public abstract object CurrentObject();

        public abstract bool MoveNext();

        public abstract void Reset();
    }
}
