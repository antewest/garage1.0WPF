using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GarageWPF1._0
{
    abstract class Vehicle
    {
        public string regnr { get; set; }
        public byte wheels { get; set; }
        public string color { get; set; }
        public int passengers { get; set; }
        public string name { get; set; }

        protected Vehicle(string regnr, byte wheels, string color, int passengers)
        {
            this.regnr = regnr;
            this.wheels = wheels;
            this.color = color;
            this.passengers = passengers;
            this.name = this.GetType().Name;
        }

        public override string ToString()
        {
            return String.Format("\nReg Nr: {0}  Wheels: {1}  Color: {2}  Passengers: {3} \n", regnr, wheels, color, passengers);
        }
        
    }
}
