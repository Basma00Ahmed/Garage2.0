using Garage2._0.Data;
using Garage2._0.Models.Entities;
using Garage2._0.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Garage2._0.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index(ParkedVehicle vehicle)
        {
            if (vehicle == null)
            {
                return NotFound();
            }

            var receipt = new CheckoutViewModel
            {
                Id = vehicle.Id,
                RegNo = vehicle.RegNo,
                VehicleType = vehicle.VehicleType,
                ArrivalTime = vehicle.ArrivalTime,
                EndTime = DateTime.Now,
            };

            return View(receipt);
        }
    }
}
