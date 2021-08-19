using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garage2._0.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkedVehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vehicleType = table.Column<int>(type: "int", nullable: false),
                    RegNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountOfWheels = table.Column<int>(type: "int", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkedVehicle", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ParkedVehicle",
                columns: new[] { "Id", "AmountOfWheels", "ArrivalTime", "Color", "Make", "Model", "RegNo", "vehicleType" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2021, 8, 19, 13, 38, 23, 84, DateTimeKind.Local).AddTicks(6545), "Red", "BMW", "C5", "ABC123", 0 },
                    { 2, 4, new DateTime(2021, 8, 19, 13, 38, 23, 86, DateTimeKind.Local).AddTicks(8101), "White", "Volvo", "Z7", "EFG124", 0 },
                    { 3, 4, new DateTime(2021, 8, 19, 13, 38, 23, 86, DateTimeKind.Local).AddTicks(8148), "Black", "Audi", "M09", "GHY125", 0 },
                    { 4, 4, new DateTime(2021, 8, 19, 13, 38, 23, 86, DateTimeKind.Local).AddTicks(8153), "Red", "BMW", "FF5", "LKJ126", 0 },
                    { 5, 12, new DateTime(2021, 8, 19, 13, 38, 23, 86, DateTimeKind.Local).AddTicks(8157), "Yellow", "BMW", "C95", "OPR127", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkedVehicle");
        }
    }
}
