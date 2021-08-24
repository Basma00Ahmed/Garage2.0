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
                   new ParkedVehicle { Id = 1, VehicleType = VehicleType.Car, RegNo ="CAR123" , Color="Gold", Make="BMW" , Model="525i", NoOfWheels=4, ArrivalTime = new DateTime(2021, 8, 20, 8, 0, 0) },
                   new ParkedVehicle { Id = 2, VehicleType = VehicleType.Car, RegNo = "CAR456", Color = "White", Make = "Volvo", Model = "S90 T5", NoOfWheels = 4, ArrivalTime = new DateTime(2021, 8, 20, 13, 30, 0) },
                   new ParkedVehicle { Id = 3, VehicleType = VehicleType.Car, RegNo = "CAR789", Color = "Black", Make = "Audi", Model = "RS7", NoOfWheels = 4, ArrivalTime = new DateTime(2021, 8, 20, 20, 0, 0) },
                   new ParkedVehicle { Id = 4, VehicleType = VehicleType.Bus, RegNo = "BUS123", Color = "Red", Make = "Mercedes-Benz", Model = "Traveller", NoOfWheels = 6, ArrivalTime = new DateTime(2021, 8, 21, 8, 0, 0) },
                   new ParkedVehicle { Id = 5, VehicleType = VehicleType.Bus, RegNo = "BUS456", Color = "Blue", Make = "Scania", Model = "SL Edition", NoOfWheels = 6, ArrivalTime = new DateTime(2021, 8, 21, 16, 0, 0) },
                   new ParkedVehicle { Id = 6, VehicleType = VehicleType.Truck, RegNo = "TRU123", Color = "Grey", Make = "DAF", Model = "Long Cruiser", NoOfWheels = 6, ArrivalTime = new DateTime(2021, 8, 22, 8, 0, 0) },
                   new ParkedVehicle { Id = 7, VehicleType = VehicleType.Truck, RegNo = "TRU456", Color = "Black", Make = "Scania", Model = "Heavy Loader", NoOfWheels = 8, ArrivalTime = new DateTime(2021, 8, 22, 17, 0, 0) },
                   new ParkedVehicle { Id = 8, VehicleType = VehicleType.Motorcycle, RegNo = "MCL123", Color = "Green", Make = "Yamaha", Model = "F1", NoOfWheels = 2, ArrivalTime = new DateTime(2021, 8, 23, 8, 0, 0) },
                   new ParkedVehicle { Id = 9, VehicleType = VehicleType.Bicycle, RegNo = "BCL123", Color = "Silver", Make = "BMX", Model = "Biker", NoOfWheels = 2, ArrivalTime = new DateTime(2021, 8, 23, 14, 0, 0) },
                   new ParkedVehicle { Id = 10, VehicleType = VehicleType.Airplane, RegNo = "AIR123", Color = "White", Make = "Boeing", Model = "Exclusive Air", NoOfWheels = 3, ArrivalTime = new DateTime(2021, 8, 23, 16, 50, 0) }
               );
        }
    }
}
