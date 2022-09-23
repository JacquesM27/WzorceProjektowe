using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class EmailLogSaverAdapter : ILogSaver
    {
        private EmailSender _sender = new();
        public void Save(int logStatusCode, string logMessage)
        {
            _sender.SendEmail(logMessage);
        }
    }
}
