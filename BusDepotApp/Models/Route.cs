using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusDepotApp.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string RouteDescription { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public IEnumerable<Buses> AvailableBuses { get; set; }

    }
}
