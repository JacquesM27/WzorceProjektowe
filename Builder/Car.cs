using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Car
    {
        public string Wheels { get; set; }
        public int Seats { get; set; }
        public int HorsePower { get; set; }
        public bool Infotaiment { get; set; }
        public string Paint { get; set; }
        public List<string> ExtraFeatures { get; set; } = new();

        public override string ToString()
        {
            string result = $"Wheels: {Wheels}\nHas {Seats} seats\nEngine with {HorsePower} horsepower\n";
            if (Infotaiment)
            {
                result += "\nHas infotaiment";
            }
            else
            {
                result += "\nHasn't infotaiment";
            }
            result += $"\nHas {Paint} color";
            if (ExtraFeatures != null)
            {
                result += "And has extra features: ";
                result += string.Join(", ", ExtraFeatures);
            }

            return result;
        }
    }
}
