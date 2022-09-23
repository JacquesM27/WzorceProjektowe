using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class DbManager
    {
        private static DbManager _instance;
        public DbManager() { }
        public static DbManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DbManager();
            }
            return _instance;
        }

        public void collectData()
        {

        }
    }
}
