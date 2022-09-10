using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class WagonCarBuilder : ICarBuilder
    {
        private WagonCar WagonCar = new();

        public WagonCarBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            WagonCar = new();
        }

        public void AddExtraFeature(string feature)
        {
            WagonCar.ExtraFeatures.Add(feature);
        }

        public void AddInfotaiment()
        {
            WagonCar.Infotaiment = true;
        }

        public void PaintBody(string color)
        {
            WagonCar.Paint = color;
        }


        public void SetEngine(int horsepower)
        {
            WagonCar.HorsePower = horsepower;
        }

        public void SetSeats()
        {
            WagonCar.Seats = 4;
        }

        public void SetWheels()
        {
            WagonCar.Wheels = "17 inch V-spoke 776";
        }
        public Car Build()
        {
            return WagonCar;
        }
    }
}
