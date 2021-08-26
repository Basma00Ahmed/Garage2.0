using Garage2._0.Data;
using Garage2._0.Models;
using Garage2._0.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage2._0.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly Garage2_0Context _context; // Ref. to the DB

        public StatisticsController(Garage2_0Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = new StatisticsViewModel
            {
                TotalVehicles = GetGarageCount(),
                VehicleTypes = GetVehicleTypesCountAsync(),
                TotalWheels = await GetWheelsTotalAsync(),
                TotalHrsParked = await GetParkedHrsTotalAsync(),
                AverageHrsParked = await GetParkedHrsAverageAsync()
            };
            return View(model);
        }

        private int GetGarageCount()
        {
            return _context.ParkedVehicle.Count();
        }
        
        private Dictionary<VehicleType, int> GetVehicleTypesCountAsync()
        {
            return _context.ParkedVehicle.Select(vehicle => vehicle.VehicleType)
                                              .AsEnumerable()
                                              .GroupBy(type => type)
                                              .ToDictionary(obj => obj.Key, obj => obj.Count());
        }

        // This doesn't work atm since GroupBy couldn't be evaluated at client-side.
        /*private async Task<Dictionary<VehicleType, int>> GetVehicleTypesCountAsync()
        {
            return await _context.ParkedVehicle.Select(vehicle => vehicle.VehicleType)
                                              .GroupBy(type => type)
                                              .ToDictionaryAsync(obj => obj.Key, obj => obj.Count());
        }*/

        private async Task<int> GetWheelsTotalAsync()
        {
            return await _context.ParkedVehicle.Select(v => v.NoOfWheels).SumAsync();
        }

        private async Task<double> GetParkedHrsTotalAsync()
        {
            var vehicles = await _context.ParkedVehicle.ToListAsync();

            double totalHours = 0;
            foreach (var vehicle in vehicles)
            {
                var currentTime = DateTime.Now;
                totalHours += (currentTime - vehicle.ArrivalTime).TotalHours;

                // Maybe a Switch...
                // Since we need to add a cost to a certain vehicleType
            }
            return Math.Round(totalHours, 2);
        }

        private async Task<double> GetParkedHrsAverageAsync()
        {
            var vehicles = await _context.ParkedVehicle.ToListAsync();

            double averageHours = 0;
            foreach (var vehicle in vehicles)
            {
                var currentTime = DateTime.Now;
                averageHours += (currentTime - vehicle.ArrivalTime).TotalHours;
            }
            averageHours /= _context.ParkedVehicle.Count();
            return Math.Round(averageHours, 2);
        }
    }
}
