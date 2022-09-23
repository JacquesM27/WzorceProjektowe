using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class FileLog
    {
        public void SaveDataToFile(int statusCode, string message)
        {
            Console.WriteLine($"Log saved to file ---- {statusCode} message {message}");
        }
    }
}
