using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Garage2._0.Models;

namespace Garage2._0.Data
{
    public class Garage2_0Context : DbContext
    {
        public Garage2_0Context (DbContextOptions<Garage2_0Context> options)
            : base(options)
        {

        }

        public DbSet<Garage2._0.Models.ParkedVehicle> ParkedVehicle { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ParkedVehicle>()
               .HasData(
                   new ParkedVehicle { Id = 1, vehicleType = VehicleType.Car, RegNo ="ABC123" , Color="Red", Make="BMW" , Model="C5", AmountOfWheels=4, ArrivalTime = DateTime.Now },
                   new ParkedVehicle { Id = 2, vehicleType = VehicleType.Car, RegNo = "EFG124", Color = "White", Make = "Volvo", Model = "Z7", AmountOfWheels = 4, ArrivalTime = DateTime.Now },
                   new ParkedVehicle { Id = 3, vehicleType = VehicleType.Car, RegNo = "GHY125", Color = "Black", Make = "Audi", Model = "M09", AmountOfWheels = 4, ArrivalTime = DateTime.Now },
                   new ParkedVehicle { Id = 4, vehicleType = VehicleType.Car, RegNo = "LKJ126", Color = "Red", Make = "BMW", Model = "FF5", AmountOfWheels = 4, ArrivalTime = DateTime.Now },
                   new ParkedVehicle { Id = 5, vehicleType = VehicleType.Bus, RegNo = "OPR127", Color = "Yellow", Make = "BMW", Model = "C95", AmountOfWheels = 12, ArrivalTime = DateTime.Now}
               );
        }
    }
}
