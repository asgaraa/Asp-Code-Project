using EduHome.Data;
using EduHome.Models;
using EduHome.Utilities.Helpers;
using EduHome.ViewModels.Admin;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class ServiceController : Controller
    {



        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public ServiceController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Service> posters = await _context.Services.ToListAsync();
            return View(posters);
        }

        public IActionResult Detail(int Id)
        {
            var service = _context.Services.FirstOrDefault(m => m.Id == Id);
            return View(service);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Service service)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool isExist = _context.Services.Any(m => m.Desc.ToLower().Trim() == service.Desc.ToLower().Trim());

            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu service artiq movcuddur");
                return View();
            }

            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int Id)
        {
            Service service = await _context.Services.Where(m => m.Id == Id).FirstOrDefaultAsync();
            if (service == null) return NotFound();


            return View(service);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, Service service)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (Id != service.Id) return NotFound();

            Service dbService = await _context.Services.AsNoTracking().Where(m => m.Id == Id).FirstOrDefaultAsync();

            if (dbService.Header.ToLower().Trim() == service.Header.ToLower().Trim() && dbService.Desc.ToLower().Trim() == service.Desc.ToLower().Trim())
            {
                return RedirectToAction(nameof(Index));
            }

            bool isExist = _context.Services.Any(m => m.Header.ToLower().Trim() == service.Header.ToLower().Trim() && m.Desc.ToLower().Trim() == service.Desc.ToLower().Trim());
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu Service artiq movcuddur");
                return View();
            }

            //dbCategory.Name = category.Name;
            _context.Update(service);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Id)
        {
            Service service = await _context.Services.Where(m => m.Id == Id).FirstOrDefaultAsync();

            if (service == null) return NotFound();

            //category.IsDeleted = true;
            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //        private async Task<Service> GetServiceById(int Id)
        //        {
        //            return await _context.Services.FindAsync(Id);
        //        }
        //    }
    }
}
