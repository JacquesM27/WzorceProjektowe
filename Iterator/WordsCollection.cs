using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class WordsCollection : IteratorAggregate
    {
        List<string> _words = new();
        bool _direction = false;

        public void ReverseDirection() => _direction = !_direction;
        public List<string> GetItems() => _words;
        public void AddItem(string item) => _words.Add(item);

        public override IEnumerator GetEnumerator() => new AlphabetOrderIterator(this, _direction);
    }
}
