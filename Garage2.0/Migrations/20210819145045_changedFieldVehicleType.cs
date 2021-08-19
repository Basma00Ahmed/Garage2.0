using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garage2._0.Migrations
{
    public partial class changedFieldVehicleType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "vehicleType",
                table: "ParkedVehicle",
                newName: "VehicleType");

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 16, 50, 45, 69, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 16, 50, 45, 73, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 16, 50, 45, 73, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 16, 50, 45, 73, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 16, 50, 45, 73, DateTimeKind.Local).AddTicks(7832));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VehicleType",
                table: "ParkedVehicle",
                newName: "vehicleType");

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 13, 38, 23, 84, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 13, 38, 23, 86, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 13, 38, 23, 86, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 13, 38, 23, 86, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 13, 38, 23, 86, DateTimeKind.Local).AddTicks(8157));
        }
    }
}
