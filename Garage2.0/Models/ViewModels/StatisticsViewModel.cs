using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0.Models.ViewModels
{
    public class StatisticsViewModel
    {
        [Display(Name = "Number of Vehicles")]
        public int TotalVehicles { get; set; }

        [Display(Name = "Total number per Vehicle type")]
        public Dictionary<VehicleType, int> VehicleTypes { get; set; }

        [Display(Name = "Total number of Wheels")]
        public int TotalWheels { get; set; }

        [Display(Name = "Total parked Hours")]
        public double TotalHrsParked { get; set; }

        [Display(Name = "Average parked Hours")]
        public double AverageHrsParked { get; set; }
    }
}
