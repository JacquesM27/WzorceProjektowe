using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite2
{
    public abstract class Soldier
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public int KilledPeople { get; set; }

        public Soldier(string name, string rank, int killedPeople)
        {
            Name = name;
            Rank = rank;
            KilledPeople = killedPeople;
        }

        public abstract decimal CalculateBaseSalary();

        public abstract int CalculateQuantity();

        public virtual void Add(Soldier soldier)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Soldier soldier)
        {
            throw new NotImplementedException();
        }
    }
}
