using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder3
{
    internal class ConstructionManager
    {
        //public IHomeBuilder Builder { private get; set; }
        private readonly IHomeBuilder Builder;
        public ConstructionManager(IHomeBuilder homeBuilder)
        {
            Builder = homeBuilder;
        }

        public IBuilding BuildGroundfloorHouse()
        {
            Console.WriteLine("Building ground floor house...");
            var building = Builder
                .SetLocation("London SW1A 0AA, Great Britain")
                .AddGarageToPlan(1)
                .PourFundament(100)
                .BuildWalls(6)
                .MountWindows(8)
                .BuildRoof(Enums.RoofType.Hexagonal)
                .Build();
            Builder.Reset();
            return building;
        }

        public IBuilding BuildTwoFloorApartmentWithSwimmingPool()
        {
            Console.WriteLine("Building big house...");
            var building = Builder
                .SetLocation("Pariser Platz, 10117 Berlin, Germany")
                .AddFloorToPlan()
                .PourFundament(150)
                .BuildWalls(4)
                .MountWindows(12)
                .BuildRoof(Enums.RoofType.Saltbox)
                .DigPool(100)
                .Build();
            Builder.Reset();
            return building;
        }
        public IBuilding BuildHomeInForest()
        {
            Console.WriteLine("Building forest house...");
            var building = Builder
                .SetLocation("47.69710289783189, 14.487916761223332")
                .AddFloorToPlan()
                .AddFloorToPlan()
                .PourFundament(200)
                .BuildWalls(8)
                .MountWindows(16)
                .BuildRoof(Enums.RoofType.Hip)
                .Build();
            Builder.Reset();
            return building;
        }
    }
}
