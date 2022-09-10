using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ModernTable : ITable
    {
        public string PartyTime(ISofa sofa, IChair chair)
        {
            return "(╯◉ᴥ◉）╯︵ ┻━┻ ¯\\_(^ᨎ^)_/¯ (∩^ω^)⊃━☆ﾟ.*";
        }

        public string PutCoffeHere()
        {
            return "Sorry, I spilled coffee on the modern table";
        }
    }
}
