using BusDepotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusDepotApp.Repository
{
    public static class BusDepoRepository 
    {
        private static List<Buses> busList = new List<Buses>() {
            new Buses(){ BusNumber="DL03PM2320",Id=1,Capacity=50, Occupency=25, CurrentFuelConsumed=60,
            FuelTankCapacity=200, TotalKMDriven = 12000, LastServicedOn = DateTime.Now.AddMonths(-1), CurrentLocation = GetLocationById(1), Incidents = new List<Incident>() { (GetIncidentById(1)) } },
            new Buses(){ BusNumber="DL02PM4520",Id=1,Capacity=50, Occupency=25, CurrentFuelConsumed=60,
            FuelTankCapacity=200, TotalKMDriven = 14000, LastServicedOn = DateTime.Now.AddMonths(-1), CurrentLocation = GetLocationById(2) },
            new Buses(){ BusNumber="DL02PM5620",Id=1, Capacity=50, Occupency=25, CurrentFuelConsumed=60, 
            FuelTankCapacity=200,TotalKMDriven = 16000, LastServicedOn = DateTime.Now.AddMonths(-1), CurrentLocation = GetLocationById(3) }
        };

        private static List<Location> locationList = new List<Location>()
        {
            new Location() {Id =1, LocationDescription = "First Loc", Latitude = 20, Longitude = 30},
            new Location() {Id =2, LocationDescription = "First Loc", Latitude = 30, Longitude = 40},
            new Location() {Id =1, LocationDescription = "First Loc", Latitude = 400, Longitude = 50},

        };

        private static List<Incident> incidentList = new List<Incident>()
        {
            new Incident () {Id = 1, IncidentTime = DateTime.Now, IncidentDescription = "Incident 1", IncidentLocation = GetLocationById(1)},
            new Incident () {Id = 2, IncidentTime = DateTime.Now, IncidentDescription = "Incident 2", IncidentLocation = GetLocationById(2)},
            new Incident () {Id = 3, IncidentTime = DateTime.Now, IncidentDescription = "Incident 3", IncidentLocation = GetLocationById(3)}
        };

        private static List<Maintenance> maintenanceList = new List<Maintenance>()
        {
            new Maintenance() { Id = 1, EligibleDistance = 10000, EligibleDurationInMonths = 12, MaintenanceOccuarance = 1, MaintenceTitle = "First Maintenance"},
            new Maintenance() { Id = 2, EligibleDistance = 20000, EligibleDurationInMonths = 24, MaintenanceOccuarance = 2, MaintenceTitle = "Second Maintenance"},
            new Maintenance() { Id = 3, EligibleDistance = 40000, EligibleDurationInMonths = 48, MaintenanceOccuarance = 1, MaintenceTitle = "Third Maintenance"}
        };

        private static Maintenance GetMaintenanceById(int id)
        {
            return maintenanceList.FirstOrDefault(a => a.Id == id);
        }

        public static IEnumerable<Maintenance> GetAllMaintenances()
        {
            return maintenanceList;
        }

        public static IEnumerable<Incident> GetAllIncidents()
        {
            return incidentList;
        }

        public static Incident GetIncidentById(int id)
        {
            return incidentList.FirstOrDefault(a => a.Id == id);
        }

        public static IEnumerable<Location> GetAllLocations()
        {
            return locationList;
        }
        
        public static Location GetLocationById(int id)
        {
            return locationList.FirstOrDefault(a => a.Id == id);
        }

        public static IEnumerable<Buses> GetAllBuses()
        {
            return busList;
        }

        public static Buses GetBus(int busid)
        {
            var bus = busList.FirstOrDefault(b => b.Id == busid);
            return bus;
        }
        
        // Routes need to be created in the same way
           
    }
}
