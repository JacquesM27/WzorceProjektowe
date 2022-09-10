using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        private ICarBuilder carBuilder;

        public ICarBuilder CarBuilder
        {
            set { carBuilder = value; }
        }

        public Car BuildBasicCar()
        {
            carBuilder.SetWheels();
            carBuilder.SetSeats();
            carBuilder.SetEngine(100);
            carBuilder.PaintBody("white");
            var buildCar = carBuilder.Build();
            carBuilder.Reset();
            return buildCar;
        }

        public Car BuildPremiumCar()
        {
            carBuilder.SetWheels();
            carBuilder.SetSeats();
            carBuilder.SetEngine(600);
            carBuilder.AddInfotaiment();
            carBuilder.PaintBody("Black pearl");
            carBuilder.AddExtraFeature("Sport leather seats");
            carBuilder.AddExtraFeature("Heated seats");
            carBuilder.AddExtraFeature("Bulletproof windows");
            carBuilder.AddExtraFeature("LED Headlights");
            carBuilder.AddExtraFeature("Louder exhaust");
            carBuilder.AddExtraFeature("Autopilot");
            var buildCar = carBuilder.Build();
            carBuilder.Reset();
            return buildCar;
        }
    }
}
