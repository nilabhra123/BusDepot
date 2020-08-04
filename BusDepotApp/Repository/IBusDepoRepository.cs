using BusDepotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusDepotApp.Repository
{
    public interface IBusDepoRepository
    {
        IEnumerable<Buses> GetAllBuses();
        Buses GetBus(int busid);
        Location GetBusLocation(int busId);
        IEnumerable<Maintenance> GetMaintenanceInfo(int busId);
    }
}
