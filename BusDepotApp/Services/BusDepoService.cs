using BusDepotApp.Dto;
using BusDepotApp.Models;
using BusDepotApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusDepotApp.Services
{
    public class BusDepoService : IBusDepoService {
        private readonly IBusDepoRepository _busDepoRepository ;
        public BusDepoService(IBusDepoRepository busDepoRepository)
        {
            _busDepoRepository = busDepoRepository;
        }

        public Buses GetBus(int busid)
        {
            return  _busDepoRepository.GetBus(busid);
        }
        public IEnumerable<Buses> GetAllBus()
        {
            return _busDepoRepository.GetAllBuses();
        }
       public Location GetBusLocation(int busId)
        {
            return _busDepoRepository.GetBusLocation(busId);
        }

        public MaitanenceDto CalculateTimeToMaintainence(int busId)
        {
            var bus = _busDepoRepository.GetBus(busId);

            //Logic for Maintainence Calculation 

            if (bus.TotalKMDriven - bus.Maintenances.LastOrDefault().KmCoveredInLastMaintainence > 1000 || (DateTime.Now - bus.LastServicedOn).TotalDays > 30)
            {
                return new MaitanenceDto() { MaintaienceRequired = true, LastMaintainenceDate = bus.LastServicedOn, KMSCoveredSinceLastMaintainence = bus.TotalKMDriven - bus.Maintenances.LastOrDefault().KmCoveredInLastMaintainence };
            }

            else return new MaitanenceDto() { MaintaienceRequired = false, LastMaintainenceDate = bus.LastServicedOn, KMSCoveredSinceLastMaintainence = bus.TotalKMDriven - bus.Maintenances.LastOrDefault().KmCoveredInLastMaintainence };
            ;
        }

        public double GetFuelConsumptionPercentage(int busId)
        {
            var bus= _busDepoRepository.GetBus(busId);
            var consumedPercentage= bus.CurrentFuelConsumed / bus.FuelTankCapacity*100;

            return consumedPercentage;
        }

        public IEnumerable<Incident> GetIncidents()
        {
            return _busDepoRepository.GetIncidents();
        }

    }
}
