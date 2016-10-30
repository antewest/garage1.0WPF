using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageWPF1._0
{
    class GarageManager
    {
        private List<Garage<Vehicle>> garageList = new List<Garage<Vehicle>>();

        public GarageManager()
        {
            //CreateExampleGarage();
        }

        public string AddVehicle(int garageIndex, Vehicle vehicle)
        {
            if (garageList[garageIndex].Count() >= garageList[garageIndex].slots)
                return "Sorry, the garage is full";
          
            garageList[garageIndex].AddVehicle(vehicle);
            return "Vehicle Added"; //String.Format("Added\n{0}", vehicle.ToString());
        }

        public void RemoveVehicle(int garageIndex, int vehicleIndex)
        {
            garageList[garageIndex].RemoveVehicle(vehicleIndex);
        }

        public void CreateExampleGarage()
        {
            CreateGarage(30, "Example Garage");

            List<Vehicle> exampleVehicles = new List<Vehicle>()
            {
                new Vehicles.Car("GNU-453",4,"Red",5,false, false),
                new Vehicles.Boat("FUU-123", 0, "White", 16, false, 50),
                new Vehicles.Bus("LUL-000",4,"Blue", 50, true, 25.00f),
                new Vehicles.Airplane("HUE-001", 18, "White", 118, "RyanAir", false),
                new Vehicles.Airplane("HUE-002", 18, "Blue", 118, "FlyEmirates", false),
                new Vehicles.Airplane("HUE-003", 18, "Red", 118, "SAS", false),
                new Vehicles.Motorcycle("GNU-453",4,"Red",5, true, false),
                new Vehicles.Motorcycle("FUU-123", 0, "White", 16, false, true),
                new Vehicles.Bus("LUL-000",4,"Blue", 50, true, 25.00f),
                new Vehicles.Airplane("HUE-004", 18, "Green", 118, "RyanAir", false),
                new Vehicles.Car("FRU-023",4,"Blue",5,false, false),
                new Vehicles.Car("EGU-113",4,"Blue",5,false, true),
                new Vehicles.Car("GTU-413",4,"Red",5,true, false),
                new Vehicles.Motorcycle("FUU-123", 0, "White", 16, false, true),
                new Vehicles.Bus("LUL-000",4,"Blue", 50, true, 25.00f),
                new Vehicles.Airplane("HUE-004", 18, "Green", 118, "RyanAir", false),
                new Vehicles.Car("FRU-023",4,"Blue",5,false, false),
                new Vehicles.Car("EGU-113",4,"Blue",5,false, true),
                new Vehicles.Car("GTU-413",4,"Red",5,true, false)
            };

            foreach (var vehicle in exampleVehicles)
            {
                AddVehicle(0, vehicle);
            }
        }

        public void CreateGarage(int numslots, string name)
        {
            Garage<Vehicle> garage = new Garage<Vehicle>{slots = numslots, name = name};
            garageList.Add(garage);
        }

        public List<Vehicle> GetAll(int garageIndex)
        {
            return garageList[garageIndex].GetVehicles();
        }

        public List<Vehicle> SearchBy(string searchProperty, string searchQuery, int garageIndex)
        {
            var listToSearch = garageList[garageIndex];

            var query = listToSearch.Where(b => b.GetProperty(searchProperty).ToString() == searchQuery);

            return query.ToList();
        }

        public IEnumerable<List<Vehicle>> GroupBy(string groupProperty, List<Vehicle> queryList)
        {
            IEnumerable<List<Vehicle>> query = queryList.GroupBy(b => b.GetProperty(groupProperty))
                                  .Select(g => g.ToList());

            return query;
        }

        //public List<Vehicle> SortBy(string sortProperty, List<Vehicle> queryList)
        //{
        //    var query = queryList.OrderBy(b => b.GetProperty(sortProperty));

        //    return query.ToList();
        //}

        public ObservableCollection<Vehicle> SortBy(string sortProperty, ObservableCollection<Vehicle> queryList)
        {
            var query = queryList.OrderBy(b => b.GetProperty(sortProperty));

            return new ObservableCollection<Vehicle>(query);
        }

        public ObservableCollection<Vehicle> SortByDesc(string sortProperty, ObservableCollection<Vehicle> queryList)
        {
            var query = queryList.OrderByDescending(b => b.GetProperty(sortProperty));

            return new ObservableCollection<Vehicle>(query);
        }
    }
}
