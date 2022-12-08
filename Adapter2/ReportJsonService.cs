using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    public class ReportJsonService
    {
        private readonly List<JsonObject> ReportData = new();

        public void AddDataToReport(JsonObject jsonObject)
        {
            ReportData.Add(jsonObject);
        }

        public void PrintReport()
        {
            double total = ReportData.Sum(r => r.Value);
            Console.WriteLine($"Total value of transfers: {total}");
        }
    }
}
