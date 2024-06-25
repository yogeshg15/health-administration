using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAdministrationSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly HealthAdministrationSystemDbContext _context;

        public AdminController(HealthAdministrationSystemDbContext context)
        {
            _context = context;
        }

        // GET: Admin/AddDoctor
        public IActionResult AddDoctor()
        {
            return View();
        }

        // POST: Admin/AddDoctor
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddDoctor([Bind("Id,Name,Specialization,Hospital")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doctor);
        }

        // GET: Admin/AddPatient
        public IActionResult AddPatient()
        {
            return View();
        }

        // POST: Admin/AddPatient
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPatient([Bind("Id,Name,Age,Address")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        // GET: Admin/AddStaff
        public IActionResult AddStaff()
        {
            return View();
        }

        // POST: Admin/AddStaff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddStaff([Bind("Id,Name,Role,Hospital")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(staff);
        }

        // GET: Admin/RemoveDoctor
        public IActionResult RemoveDoctor()
        {
            return View();
        }

        // POST: Admin/RemoveDoctor
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveDoctor([Bind("Id")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _context.Remove(doctor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doctor);
        }

        // GET: Admin/RemovePatient
        public IActionResult RemovePatient()
        {
            return View();
        }

        // POST: Admin/RemovePatient
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemovePatient([Bind("Id")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                _context.Remove(patient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        // GET: Admin/RemoveStaff
        public IActionResult RemoveStaff()
        {
            return View();
        }

        // POST: Admin/RemoveStaff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveStaff([Bind("Id")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                _context.Remove(staff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(staff);
        }
    }
}