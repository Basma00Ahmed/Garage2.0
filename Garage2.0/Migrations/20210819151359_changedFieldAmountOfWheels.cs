using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garage2._0.Migrations
{
    public partial class changedFieldAmountOfWheels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AmountOfWheels",
                table: "ParkedVehicle",
                newName: "NoOfWheels");

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 17, 13, 58, 548, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 17, 13, 58, 553, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 17, 13, 58, 553, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 17, 13, 58, 553, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "ParkedVehicle",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArrivalTime",
                value: new DateTime(2021, 8, 19, 17, 13, 58, 553, DateTimeKind.Local).AddTicks(5889));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NoOfWheels",
                table: "ParkedVehicle",
                newName: "AmountOfWheels");

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
    }
}
