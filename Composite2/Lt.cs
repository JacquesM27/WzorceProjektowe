using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite2
{
    internal class Lt : Pte
    {
        private List<Soldier> soldiers = new();
        public Lt(string name, string rank, int killedPeople) : base(name, rank, killedPeople)
        {
        }

        public override int CalculateQuantity()
        {
            return soldiers.Count;
        }

        public override decimal CalculateBaseSalary()
        {
            decimal salary = (soldiers.Sum(x => x.CalculateQuantity()) * 5000) - soldiers.Sum(x => x.CalculateBaseSalary());
            Console.WriteLine($"Lieutenant  {Name} mentees {soldiers.Count} - calculated salary = {salary}");
            return salary;
        }

        public override void Add(Soldier soldier)
        {
            soldiers.Add(soldier);
        }

        public override void Remove(Soldier soldier)
        {
            soldiers.Remove(soldier);
        }
    }
}
