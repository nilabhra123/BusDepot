using BusDepotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusDepotApp.Repository
{
    public class BusDepoRepository : IBusDepoRepository
    {
        private readonly List<Buses> busList = new List<Buses>() {
            new Buses(){ BusNumber="DL03PM2320",Id=1,Capacity=50, Occupency=25, CurrentFuelConsumed=60,
            FuelTankCapacity=200 },
            new Buses(){ BusNumber="DL02PM4520",Id=1,Capacity=50, Occupency=25, CurrentFuelConsumed=60,
            FuelTankCapacity=200 },
            new Buses(){ BusNumber="DL02PM5620",Id=1,Capacity=50, Occupency=25, CurrentFuelConsumed=60,
            FuelTankCapacity=200 }
        };

        public IEnumerable<Buses> GetAllBuses()
        {
            return busList.ToList();
        }

        public Buses GetBus(int busid)
        {
            var bus = busList.FirstOrDefault(b => b.Id == busid);
            return bus;
        }
        

           
    }
}
