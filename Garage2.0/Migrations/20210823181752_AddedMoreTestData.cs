using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garage2._0.Migrations
{
    public partial class AddedMoreTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkedVehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleType = table.Column<int>(type: "int", nullable: false),
                    RegNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfWheels = table.Column<int>(type: "int", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkedVehicle", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ParkedVehicle",
                columns: new[] { "Id", "ArrivalTime", "Color", "Make", "Model", "NoOfWheels", "RegNo", "VehicleType" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), "Gold", "BMW", "525i", 4, "CAR123", 4 },
                    { 2, new DateTime(2021, 8, 20, 13, 30, 0, 0, DateTimeKind.Unspecified), "White", "Volvo", "S90 T5", 4, "CAR456", 4 },
                    { 3, new DateTime(2021, 8, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), "Black", "Audi", "RS7", 4, "CAR789", 4 },
                    { 4, new DateTime(2021, 8, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "Red", "Mercedes-Benz", "Traveller", 6, "BUS123", 3 },
                    { 5, new DateTime(2021, 8, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), "Blue", "Scania", "SL Edition", 6, "BUS456", 3 },
                    { 6, new DateTime(2021, 8, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), "Grey", "DAF", "Long Cruiser", 6, "TRU123", 6 },
                    { 7, new DateTime(2021, 8, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), "Black", "Scania", "Heavy Loader", 8, "TRU456", 6 },
                    { 8, new DateTime(2021, 8, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), "Green", "Yamaha", "F1", 2, "MCL123", 5 },
                    { 9, new DateTime(2021, 8, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), "Silver", "BMX", "Biker", 2, "BCL123", 1 },
                    { 10, new DateTime(2021, 8, 23, 16, 50, 0, 0, DateTimeKind.Unspecified), "White", "Boeing", "Exclusive Air", 3, "AIR123", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkedVehicle");
        }
    }
}
