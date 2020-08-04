using BusDepotApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusDepotApp.Services
{
   public interface IBusDepoService
    {
        Buses GetBus(int busid);
        IEnumerable<Buses> GetAllBus();
        Location GetBusLocation(int busId);
        IEnumerable<Incident> GetIncidents();

    }
}
