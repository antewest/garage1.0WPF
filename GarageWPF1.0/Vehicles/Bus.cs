using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageWPF1._0.Vehicles
{
    class Bus : Vehicle
    {
        public bool isChartered { get; set; }
        public float ticketPrice { get; set; }


        public Bus(string regnr, byte wheels, string color, int passengers, bool isChartered, float ticketPrice) : base(regnr, wheels, color,passengers)
        {
            this.isChartered = isChartered;
            this.ticketPrice = ticketPrice;
        }

        public override string ToString()
        {
            return string.Format("Bus   Chartered: {0}  Ticket Price: {1}", isChartered ? "Yes" : "No", ticketPrice) + base.ToString();
        }
    }
}
