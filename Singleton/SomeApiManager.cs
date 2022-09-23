using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class SomeApiManager
    {
        private SomeApiManager() { }
        private static SomeApiManager _instance;
        private static readonly object _lock = new();
        public static SomeApiManager GetInstance(string testValue)
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    if (_instance is null)
                    {
                        _instance = new SomeApiManager();
                        _instance.TestObject = testValue;
                    }
                }
            }
            return _instance;
        }
        public string TestObject { get; set; }
    }
}
