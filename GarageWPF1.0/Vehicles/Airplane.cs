using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GarageWPF1._0.Vehicles
{
    class Airplane: Vehicle
    {
        public string flightCompany { get; set; }
        public bool isJetplane { get; set; }
        
        public Airplane(string regnr, byte wheels, string color, int passengers, string flightCompany, bool isJetplane) : base(regnr, wheels, color,passengers)
        {
            this.flightCompany = flightCompany;
            this.isJetplane = isJetplane;
        }

        public override string ToString()
        {
            return string.Format("Airplane   Flight Company: {0}  Is it a Jetplane: {1}",flightCompany, isJetplane ? "Yes" : "No")+base.ToString();
        }
    }
}
