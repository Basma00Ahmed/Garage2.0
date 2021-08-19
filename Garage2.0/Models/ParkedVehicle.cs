using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Garage2._0.Models
{

    public class ParkedVehicle
    {
        public ParkedVehicle()
        {

        } 
        public int Id { get; set; }

        [Required]
     
        public VehicleType vehicleType { get; set; }

        [Required]
        public string RegNo { get; set; }

        [Range (1,30)]
        public string Color { get; set; }

        [Required]
        [Range(1, 30)]
        public string Make { get; set; }

        [Range(1, 30)]
        public string Model { get; set; }

        [Range(1, 12)]
        public int AmountOfWheels { get; set; }

        public DateTime ArrivalTime  { get; set; }

    }
       
}
