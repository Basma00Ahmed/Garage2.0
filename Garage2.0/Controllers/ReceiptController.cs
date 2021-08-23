using Garage2._0.Data;
using Garage2._0.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Garage2._0.Controllers
{
    public class ReceiptController : Controller
    {
        private readonly Garage2_0Context _context;

        public ReceiptController(Garage2_0Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            var parkedVehicle = await _context.ParkedVehicle.FirstOrDefaultAsync(vehicle => vehicle.Id == id);

            ReceiptViewModel receipt = null;
            if (parkedVehicle != null)
            {
                receipt = new ReceiptViewModel
                {
                    Id = parkedVehicle.Id,
                    RegNo = parkedVehicle.RegNo,
                    ArrivalTime = parkedVehicle.ArrivalTime,
                    EndTime = DateTime.Now,
                    HourlyRate = 5,
                };
                receipt.TotalTime = (decimal)Math.Round((receipt.EndTime - receipt.ArrivalTime).TotalHours, 2);
                receipt.TotalCost = Math.Round(receipt.TotalTime * receipt.HourlyRate, 2);
            }
            return View(receipt);
        }
    }
}
