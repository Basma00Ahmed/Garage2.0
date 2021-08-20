using System;
using System.ComponentModel.DataAnnotations;


namespace Garage2._0.Models.Entities
{

    public class ParkedVehicle
    {
        public ParkedVehicle()
        {

        } 
        public int Id { get; set; }

        [Required]
        [Display(Name = "Vehicle type")]
        public VehicleType VehicleType { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Registration No")]
        public string RegNo { get; set; }

        [MaxLength (10)]
        public string Color { get; set; }

        [Required]
        [MaxLength(10)]
        public string Make { get; set; }

        [MaxLength(10)]
        public string Model { get; set; }

        [Range(1, 12)]
        [Display(Name = "Number of wheels")]
        public int NoOfWheels { get; set; }

        [Display(Name = "Arrival time")]
        public DateTime ArrivalTime  { get; set; }

    }
       
}
