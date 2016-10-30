using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageWPF1._0
{
    class Garage<T>:IEnumerable<T> where T:Vehicle
    {
        public string name { get; set; }
        public int slots { get; set; }
        private List<T> vehiclesInGarage = new List<T>();

        public void AddVehicle(T vehicle)
        {
            vehiclesInGarage.Add(vehicle);
        }

        public void RemoveVehicle(int index)
        {
            vehiclesInGarage.RemoveAt(index);
        }

        //Implement IEnumerable

        public IEnumerator<T> GetEnumerator()
        {
            return vehiclesInGarage.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    
        internal List<T> GetVehicles()
        {
 	        return vehiclesInGarage;
        }
    }
}
