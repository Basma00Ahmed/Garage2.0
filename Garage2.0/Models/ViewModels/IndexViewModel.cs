using System;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0.Models.ViewModels
{
    public class IndexViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Vehicle Type")]
        public VehicleType VehicleType { get; set; }

        [Display(Name = "Registration No")]
        public string RegNo { get; set; }

        [Display(Name = "Arrival time")]
        public DateTime ArrivalTime { get; set; }

    }
}
