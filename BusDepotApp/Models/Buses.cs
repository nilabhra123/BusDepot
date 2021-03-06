﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusDepotApp.Models
{
    public class Buses
    {
        public int Id { get; set; }
        public string BusNumber { get; set; }
        public int Capacity { get; set; }
        public int Occupency { get; set; }
        public double FuelTankCapacity { get; set; }
        public double CurrentFuelConsumed { get; set; }
        public double AverageTimeInRoute { get; set; }
        public DateTime LastServicedOn { get; set; }
        public double TotalKMDriven { get; set; }
        public Location CurrentLocation { get; set; }
        public IEnumerable<Maintenance> Maintenances { get; set; }
    }
}
