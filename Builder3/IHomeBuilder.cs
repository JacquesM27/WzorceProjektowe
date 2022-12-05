using Builder3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder3
{
    public interface IHomeBuilder
    {
        IHomeBuilder SetLocation(string location);
        IHomeBuilder AddFloorToPlan();
        IHomeBuilder AddGarageToPlan(int cars);
        IHomeBuilder PourFundament(double area);
        IHomeBuilder BuildWalls(int count);
        IHomeBuilder MountWindows(int count);
        IHomeBuilder BuildRoof(RoofType roofType);
        IHomeBuilder DigPool(int area);
        IHomeBuilder PlantTrees(int count);
        IBuilding Build();
        void Reset();
    }
}
