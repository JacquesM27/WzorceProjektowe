using Builder3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder3
{
    public abstract class Building : IBuilding
    {
        public double Area { get; set; }
        public string Location { get; set; }
        public int Floors { get; set; } = 1;
        public int Walls { get; set; }
        public RoofType Roof { get; set; }
        public int Windows { get; set; }
        public int PoolArea { get; set; } = 0;
        public int GarageArea { get; set; }
        public int Trees { get; set; }
    }
}
