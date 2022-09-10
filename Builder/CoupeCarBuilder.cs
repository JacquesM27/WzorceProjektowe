using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class CoupeCarBuilder : ICarBuilder
    {
        private CoupeCar CoupeCar = new();

        public CoupeCarBuilder()
        {
            Reset();
        }
        
        public void Reset()
        {
            CoupeCar = new CoupeCar();
        }
        public void AddExtraFeature(string feature)
        {
            CoupeCar.ExtraFeatures.Add(feature);
        }

        public void AddInfotaiment()
        {
            CoupeCar.Infotaiment = true;
        }

        public void PaintBody(string color)
        {
            CoupeCar.Paint = color;
        }

        public void SetEngine(int horsepower)
        {
            CoupeCar.HorsePower = horsepower;
        }

        public void SetSeats()
        {
            CoupeCar.Seats = 2;
        }

        public void SetWheels()
        {
            CoupeCar.Wheels = "19 inch lightweight";
        }

        public Car Build()
        {
            return CoupeCar;
        }
    }
}
