using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite2
{
    internal class Pte : Soldier
    {
        public Pte(string name, string rank, int killedPeople) : base(name, rank, killedPeople)
        {
            name = Name;
            rank = Rank;
            killedPeople = KilledPeople;
        }

        public override decimal CalculateBaseSalary()
        {
            decimal salary = (decimal)(2000 + (KilledPeople * 10));
            Console.WriteLine($"Private {Name} killed {KilledPeople} - calculated salary = {salary}");
            return salary;
        }

        public override int CalculateQuantity()
        {
            return 1;
        }
    }
}
