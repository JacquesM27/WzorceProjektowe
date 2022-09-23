using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class FileLogSaverAdapter : ILogSaver
    {
        private readonly FileLog _logger = new();
        public void Save(int logStatusCode, string logMessage)
        {
            _logger.SaveDataToFile(logStatusCode, logMessage);
        }
    }
}
