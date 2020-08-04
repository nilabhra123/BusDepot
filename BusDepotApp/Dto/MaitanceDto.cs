using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusDepotApp.Dto
{
    public class MaitanenceDto
    {
        public bool MaintaienceRequired { get; set; }
        public DateTime LastMaintainenceDate { get; set; }
        public double KMSCoveredSinceLastMaintainence { get; set; }

    }
}
