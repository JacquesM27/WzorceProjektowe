using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class SqlLogSaverAdapter : ILogSaver
    {
        private SqlLog SqlLog = new();

        public void Save(int logStatusCode, string logMessage)
        {
            SqlLog.SaveDataToTable(logStatusCode, logMessage);
        }
    }
}
