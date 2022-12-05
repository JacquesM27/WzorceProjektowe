using Builder3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder3
{
    internal class HomeBuilder : IHomeBuilder
    {
        private Home home = new();
        public IHomeBuilder AddFloorToPlan()
        {
            home.Floors++;
            return this;
        }
        public IHomeBuilder AddGarageToPlan(int cars)
        {
            int squareMetersPerCar = 25;
            int targetGarageArea = cars * squareMetersPerCar;
            home.GarageArea = targetGarageArea;
            return this;
        }
        public IHomeBuilder BuildRoof(RoofType roofType)
        {
            home.Roof = roofType;
            return this;
        }
        public IHomeBuilder BuildWalls(int count)
        {
            home.Walls = count;
            return this;
        }
        public IHomeBuilder DigPool(int area)
        {
            home.PoolArea = area;
            return this;
        }
        public IHomeBuilder MountWindows(int count)
        {
            home.Windows = count;
            return this;
        }
        public IHomeBuilder PlantTrees(int count)
        {
            home.Trees = count;
            return this;
        }
        public IHomeBuilder PourFundament(double area)
        {
            home.Area = area;
            return this;
        }
        public IBuilding Build()
        {
            return home;
        }
        public void Reset()
        {
            home = new();
        }
        public IHomeBuilder SetLocation(string location)
        {
            home.Location = location;
            return this;
        }
    }
}
