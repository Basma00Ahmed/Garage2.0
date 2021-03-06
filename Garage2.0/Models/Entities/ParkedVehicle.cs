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

        [RegularExpression(@"([a-zA-ZäöåÄÖÅ)]{3})([0-9]{3})$", ErrorMessage = "Invalid format ex: ABC123.")]
        [Required]
        [MaxLength(6)]
        // [Remote(action: "VerifyRegNo", controller: "ParkedVehicles")] släckt så länge
        [Display(Name = "Registration No")]
        public string RegNo { get; set; }

        [RegularExpression(@"[a-zA-ZäöåÄÖÅ)]{3,}$", ErrorMessage = "This is not a valid color")]
        [MaxLength(10)]
        public string Color { get; set; }

        [Required]
        [MaxLength(20)]
        [RegularExpression(@"[a-zA-Z \s)]{3,}$", ErrorMessage = "This is not a valid Make")]
        public string Make { get; set; }

        [MaxLength(20)]
        [RegularExpression(@"[a-zA-Z0-9) \s]{2,}$", ErrorMessage = "This is not a valid Model")]
        public string Model { get; set; }

        [Range(0, 12, ErrorMessage = "Number of wheels must be between 0 and 12")]
        [Display(Name = "Number of wheels")]
        public int NoOfWheels { get; set; }

        [Display(Name = "Arrival time")]
        [DataType(DataType.DateTime)]
        public DateTime ArrivalTime { get; set; }

    }

}
