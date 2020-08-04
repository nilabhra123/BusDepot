using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusDepotApp.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string LocationDescription { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
 
    }
}
