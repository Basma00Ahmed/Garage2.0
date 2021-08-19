using Garage2._0.Models;
using Garage2._0.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;


namespace Garage2._0.Data
{
    public class Garage2_0Context : DbContext
    {
        public Garage2_0Context (DbContextOptions<Garage2_0Context> options)
            : base(options)
        {

        }

        public DbSet<Garage2._0.Models.Entities.ParkedVehicle> ParkedVehicle { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ParkedVehicle>()
               .HasData(
                   new ParkedVehicle { Id = 1, VehicleType = VehicleType.Car, RegNo ="ABC123" , Color="Red", Make="BMW" , Model="C5", NoOfWheels=4, ArrivalTime = DateTime.Now },
                   new ParkedVehicle { Id = 2, VehicleType = VehicleType.Car, RegNo = "EFG124", Color = "White", Make = "Volvo", Model = "Z7", NoOfWheels = 4, ArrivalTime = DateTime.Now },
                   new ParkedVehicle { Id = 3, VehicleType = VehicleType.Car, RegNo = "GHY125", Color = "Black", Make = "Audi", Model = "M09", NoOfWheels = 4, ArrivalTime = DateTime.Now },
                   new ParkedVehicle { Id = 4, VehicleType = VehicleType.Car, RegNo = "LKJ126", Color = "Red", Make = "BMW", Model = "FF5", NoOfWheels = 4, ArrivalTime = DateTime.Now },
                   new ParkedVehicle { Id = 5, VehicleType = VehicleType.Bus, RegNo = "OPR127", Color = "Yellow", Make = "BMW", Model = "C95", NoOfWheels = 12, ArrivalTime = DateTime.Now}
               );
        }
    }
}
