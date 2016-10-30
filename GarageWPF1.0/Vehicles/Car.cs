using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageWPF1._0.Vehicles
{
    class Car : Vehicle
    {

        public bool isElectric { get; set; }
        public bool isRaggarbil { get; set; }

        public Car(string regnr, byte wheels, string color, int passengers, bool isElectric, bool isRaggarbil) : base(regnr, wheels, color,passengers)
        {
            this.isElectric = isElectric;
            this.isRaggarbil = isRaggarbil;
        }

        public override string ToString()
        {
            return string.Format("Car   Is is Electric: {0}  Is it a Raggarbil: {1}", isElectric ? "Yes" : "No", isRaggarbil ? "Yes" : "No") + base.ToString();
        }
    }
}
