using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusDepotApp.Models
{
    public class Maintenance
    {
        public int Id { get; set; }
        public string MaintenceTitle { get; set; }
        public int MaintenanceOccuarance { get; set; }
        public int EligibleDistance { get; set; }
        public int EligibleDurationInMonths { get; set; }
        public DateTime MaintenanceDate { get; set; }
    }
}
