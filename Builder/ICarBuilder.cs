using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICarBuilder
    {
        void Reset();
        void SetWheels();
        void SetSeats();
        void SetEngine(int horsepower);
        void AddInfotaiment();
        void PaintBody(string color);
        void AddExtraFeature(string feature);
        Car Build();

    }
}
