using System;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0.Models.ViewModels
{
    public class ReceiptViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Registration No")]
        public string RegNo { get; set; }

        [Display(Name = "From")]
        public DateTime ArrivalTime { get; set; }

        [Display(Name = "To")]
        public DateTime EndTime { get; set; }

        [Display(Name = "Total Time")]
        public decimal TotalTime { get; set; }

        [Display(Name = "Hourly Rate")]
        public int HourlyRate { get; set; }

        [Display(Name = "Total Cost")]
        public decimal TotalCost { get; set; }
    }
}
