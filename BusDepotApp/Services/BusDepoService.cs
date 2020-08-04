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

        public DateTime CalculateTimeToMaintainence(int busId)
        {
            var busMaintainenceInfo = _busDepoRepository.GetMaintenanceInfo(busId);
            //Logic for Maintance Calculation 

            return DateTime.Now;// to be replaced with the final result 
        }

        public IEnumerable<Incident> GetIncidents()
        {
            return _busDepoRepository.GetIncidents();
        }

    }
}
