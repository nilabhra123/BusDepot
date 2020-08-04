using BusDepotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusDepotApp.Repository
{
    public class BusDepoRepository : IBusDepoRepository
    {
        private List<Buses> busList = new List<Buses>() {
            new Buses(){ BusNumber="DL03PM2320",Id=1,Capacity=50, Occupency=25, CurrentFuelConsumed=60,AverageTimeInRoute=3.2,TotalKMDriven=2300,
            FuelTankCapacity=200 },
            new Buses(){ BusNumber="DL02PM4520",Id=2,Capacity=50, Occupency=25, CurrentFuelConsumed=60,AverageTimeInRoute=3.8,TotalKMDriven=4500,
            FuelTankCapacity=200 },
            new Buses(){ BusNumber="DL02PM5620",Id=3,Capacity=50, Occupency=25, CurrentFuelConsumed=60,AverageTimeInRoute=3.5,TotalKMDriven=4900,
            FuelTankCapacity=200 }
        };
        public BusDepoRepository()
        {
            busList[0].CurrentLocation = new Location() { Id = 1, Latitude = 12.9778, Longitude = 77.5936, Time=DateTime.Now };
            busList[1].CurrentLocation = new Location() { Id = 2, Latitude = 12.9723, Longitude = 77.5916, Time = DateTime.Now };
            busList[2].CurrentLocation = new Location() { Id = 3, Latitude = 12.9745, Longitude = 77.5921, Time = DateTime.Now };
            busList[0].Maintenances = new List<Maintenance>{ new Maintenance() { KmCoveredInLastMaintainence = 200, LastMaintenceDate = DateTime.Now.AddDays(-300) } };
            busList[1].Maintenances = new List<Maintenance> { new Maintenance() { KmCoveredInLastMaintainence = 400, LastMaintenceDate = DateTime.Now.AddDays(-20) } };
            busList[2].Maintenances = new List<Maintenance> { new Maintenance() { KmCoveredInLastMaintainence = 120000, LastMaintenceDate = DateTime.Now.AddDays(300) } };
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

        public IEnumerable<Incident> GetIncidents()
        {
            return new List<Incident>() { new Incident() { Id = 1, AffectedBus = GetBus(1), IncidentLocation = GetBusLocation(1), IncidentTime = DateTime.Now, IncidentTitle = "Breakdown" } };
        }
           
    }
}
