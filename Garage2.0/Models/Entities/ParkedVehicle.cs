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

        [Required(ErrorMessage = "Pleasee select vehicle type")]
        [Display(Name = "Vehicle type")]
        public VehicleType VehicleType { get; set; }

        [Required(ErrorMessage = "Pleasee enter Registration No")]
        [Display(Name = "Registration No")]
        public string RegNo { get; set; }

        [MaxLength(30,ErrorMessage = "Color Max lenght 30")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Pleasee enter vehicle Make")]
        [MaxLength(30, ErrorMessage = "Make Max lenght 30")]
        public string Make { get; set; }

        [MaxLength(30, ErrorMessage = "Model Max lenght 30")]
        public string Model { get; set; }

        [Range(0, 12,ErrorMessage = "Enter number between 0 to 12")]
        [Display(Name = "Number of wheels")]
        public int NoOfWheels { get; set; }

        [Display(Name = "Arrival time")]
        public DateTime ArrivalTime  { get; set; }

    }
       
}
