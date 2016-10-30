using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageWPF1._0.Vehicles
{
    class Boat : Vehicle
    {
        public float maxKnots { get; set; }
        public bool isPirateShip { get; set; }

        public Boat(string regnr, byte wheels, string color, int passengers, bool isPirateShip, float maxKnots) : base(regnr, wheels, color,passengers)
        {
            this.maxKnots = maxKnots;
            this.isPirateShip = isPirateShip;
        }

        public override string ToString()
        {
            return string.Format("Boat   Max Knots: {0}  Is it a Pirate Ship: {1}", maxKnots, isPirateShip ? "Yes" : "No") + base.ToString();
        }
    }
}
