using System;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0.Models.ViewModels
{
    public class CheckoutViewModel
    {
        //Fields
        private decimal totalTime;
        private int hourlyRate;
        private decimal totalCost;

        //Properties
        public int Id { get; set; }

        [Display(Name = "Registration No")]
        public string RegNo { get; set; }

        public VehicleType VehicleType { get; set; }

        [Display(Name = "From")]
        public DateTime ArrivalTime { get; set; }

        [Display(Name = "To")]
        public DateTime EndTime { get; set; }

        [Display(Name = "Total Time")]
        public decimal TotalTime 
        { 
            get
            {
                totalTime = (decimal)Math.Round((EndTime - ArrivalTime).TotalHours, 2);
                return totalTime;
            }
        }

        [Display(Name = "Hourly Rate")]
        public int HourlyRate
        {
            get
            {
                // Switch-statement, in a shorten way, based on VehicleType.
                hourlyRate = VehicleType switch
                {
                    VehicleType.Airplane => 50,
                    VehicleType.Bicycle => 0,
                    VehicleType.Boat => 20,
                    VehicleType.Bus => 10,
                    VehicleType.Car => 5,
                    VehicleType.Motorcycle => 2,
                    VehicleType.Truck => 10,
                    _ => 5, // Default case
                };
                return hourlyRate;
            }
        }

        [Display(Name = "Total Cost")]
        public decimal TotalCost 
        { 
            get
            {
                totalCost = Math.Round(TotalTime * HourlyRate, 2);
                return totalCost;
            }
        }
    }
}
