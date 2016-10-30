using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageWPF1._0.Vehicles
{
    class Motorcycle: Vehicle
    {
        public bool isLowrider { get; set;}
        public bool hasSideCar { get; set; }

        public Motorcycle(string regnr, byte wheels, string color, int passengers, bool isLowrider, bool hasSideCar) : base(regnr, wheels, color,passengers)
        {
            this.isLowrider = isLowrider;
            this.hasSideCar = hasSideCar;
        }

        public override string ToString()
        {
            return string.Format("Motorcycle   Lowrider: {0}  Sidecar: {1}", isLowrider ? "Yes" : "No", hasSideCar ? "Yes" : "No") + base.ToString();
        }
    }
}
