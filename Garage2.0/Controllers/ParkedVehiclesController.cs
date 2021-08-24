using Garage2._0.Data;
using Garage2._0.Models.Entities;
using Garage2._0.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Garage2._0.Controllers
{
    public class ParkedVehiclesController : Controller
    {
        private readonly Garage2_0Context _context;

        public ParkedVehiclesController(Garage2_0Context context)
        {
            _context = context;
        }

        // GET: ParkedVehicles
        public async Task<IActionResult> Index()
        {
            var model = _context.ParkedVehicle.Select(vehicle => new IndexViewModel
            {
                Id = vehicle.Id,
                VehicleType = vehicle.VehicleType,
                RegNo = vehicle.RegNo,
                ArrivalTime = vehicle.ArrivalTime
            });
            return View(await model.ToListAsync());
        }

        // GET: ParkedVehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkedVehicle = await _context.ParkedVehicle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parkedVehicle == null)
            {
                return NotFound();
            }

            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Create
        public IActionResult Create()
        {
            return View();
        }
      
        // POST: ParkedVehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VehicleType,RegNo,Color,Make,Model,NoOfWheels,ArrivalTime")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                bool regNoExists = _context.ParkedVehicle.Any(v => v.RegNo == parkedVehicle.RegNo);
                if (!regNoExists)
                {
                    parkedVehicle.RegNo = parkedVehicle.RegNo.ToUpper();
                    parkedVehicle.Color = parkedVehicle.Color.Substring(0,1).ToUpper() + parkedVehicle.Color.Substring(1);
                    parkedVehicle.Make = parkedVehicle.Make.Substring(0, 1).ToUpper() + parkedVehicle.Make.Substring(1);
                    parkedVehicle.Model = parkedVehicle.Model.Substring(0, 1).ToUpper() + parkedVehicle.Model.Substring(1);
                    parkedVehicle.ArrivalTime = System.DateTime.Now;
                    _context.Add(parkedVehicle);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("RegNo", "A vehicle with this register Number is already in the garage.");    
                }
            }
            return View(parkedVehicle);
        }

        //Validering av regnummer på klient sida
        public IActionResult VerifyRegNo(string RegNo)
        {
            bool regNoExists = _context.ParkedVehicle.Any(v => v.RegNo == RegNo);
            if (regNoExists)
            {
                return Json($"A vehicle with register Number {RegNo} is already in the garage.");
            }
            return Json(true);
        }
       

        // GET: ParkedVehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkedVehicle = await _context.ParkedVehicle.FindAsync(id);
            if (parkedVehicle == null)
            {
                return NotFound();
            }
            return View(parkedVehicle);
        }

        // POST: ParkedVehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VehicleType,RegNo,Color,Make,Model,NoOfWheels,ArrivalTime")] ParkedVehicle parkedVehicle)
        {
            if (id != parkedVehicle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    parkedVehicle.RegNo = parkedVehicle.RegNo.ToUpper();
                    _context.Update(parkedVehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParkedVehicleExists(parkedVehicle.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parkedVehicle = await _context.ParkedVehicle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parkedVehicle == null)
            {
                return NotFound();
            }

            return View(parkedVehicle);
        }

        // POST: ParkedVehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parkedVehicle = await _context.ParkedVehicle.FindAsync(id);
            _context.ParkedVehicle.Remove(parkedVehicle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParkedVehicleExists(int id)
        {
            return _context.ParkedVehicle.Any(e => e.Id == id);
        }
    }
}
