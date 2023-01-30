using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class AlphabetOrderIterator : Iterator
    {
        private WordsCollection _collection;
        private int _index = -1;
        private bool _reverse = false;

        public AlphabetOrderIterator(WordsCollection collection, bool reverse)
        {
            _collection = collection;
            _reverse = reverse;
            if (reverse)
            {
                _index = collection.GetItems().Count;
            }
        }

        public override object CurrentObject() => _collection.GetItems()[_index];
        public override int Key() => _index;
        public override bool MoveNext()
        {
            int nextPosition = _index + (_reverse? -1 : 1);
            if (nextPosition >= 0 && nextPosition < _collection.GetItems().Count)
            {
                _index= nextPosition;
                return true;
            }
            return false;
        }

        public override void Reset() => _index = _reverse ? _collection.GetItems().Count - 1 : 0;
    }
}
