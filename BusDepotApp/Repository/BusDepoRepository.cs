using BusDepotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusDepotApp.Repository
{
    public class BusDepoRepository : IBusDepoRepository
    {
        private  List<Buses> busList = new List<Buses>() {
            new Buses(){ BusNumber="DL03PM2320",Id=1,Capacity=50, Occupency=25, CurrentFuelConsumed=60,
            FuelTankCapacity=200 },
            new Buses(){ BusNumber="DL02PM4520",Id=2,Capacity=50, Occupency=25, CurrentFuelConsumed=60,
            FuelTankCapacity=200 },
            new Buses(){ BusNumber="DL02PM5620",Id=3,Capacity=50, Occupency=25, CurrentFuelConsumed=60,
            FuelTankCapacity=200 }
        };
        public BusDepoRepository()
        {
            busList[0].CurrentLocation = new Location() { Id = 1, Latitude = 22.2, Longitude = 43.2,Time=DateTime.Now };
            busList[1].CurrentLocation = new Location() { Id = 2, Latitude = 27.2, Longitude = 48.2, Time = DateTime.Now };
            busList[2].CurrentLocation = new Location() { Id = 3, Latitude = 264, Longitude = 234, Time = DateTime.Now };
        }
       

        public IEnumerable<Maintenance > GetMaintenanceInfo( int busId)
        {
            return busList.FirstOrDefault(b => b.Id == busId).Maintenances;
        }
        public IEnumerable<Buses> GetAllBuses()
        {
            return busList.ToList();
        }

        public Buses GetBus(int busid)
        {
            var bus = busList.FirstOrDefault(b => b.Id == busid);
            return bus;
        }
        
        public Location GetBusLocation(int busId)
        {
            var busLocation = busList.FirstOrDefault(b => b.Id == busId).CurrentLocation;
            return busLocation;
        }
           
    }
}
