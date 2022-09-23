using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class SqlLog
    {
        public void SaveDataToTable(int statusCode, string message)
        {
            Console.WriteLine($"SQL - saved - statusCode {statusCode} message {message}");
        }
    }
}
