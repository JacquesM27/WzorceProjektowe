using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class EmailSender
    {
        public void SendEmail(string logMessage)
        {
            Console.WriteLine($"email sent - log - {logMessage}");
        }
    }
}
