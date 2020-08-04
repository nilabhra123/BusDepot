using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusDepotApp.Models
{
    public class Incident
    {
        public int Id { get; set; }
        public string IncidentTitle { get; set; }
        public string IncidentDescription { get; set; }
        public DateTime IncidentTime { get; set; }
        public Location IncidentLocation { get; set; }
        public Buses AffectedBus { get; set; }
    }
}
