using EduHome.Data;
using EduHome.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin")]
    public class SkillController : Controller
    {
        private readonly AppDbContext _context;
        public SkillController(AppDbContext context)
        {
            _context = context;
           
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Skill> skills = await _context.Skills.ToListAsync();
            return View(skills);
        }
        #endregion


        #region Detail
        public IActionResult Detail(int Id)
        {
            var skill = _context.Skills.FirstOrDefault(m => m.Id == Id);
            return View(skill);
           
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Skill skill)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool isExist = _context.Skills.Any(m => m.Name.ToLower().Trim() == skill.Name.ToLower().Trim());

            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu skill artiq movcuddur");
                return View();
            }

            await _context.Skills.AddAsync(skill);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion


        #region Edit
        public async Task<IActionResult> Edit(int Id)
        {
            Skill skill = await _context.Skills.Where(m=>m.Id == Id).FirstOrDefaultAsync();
            if (skill == null) return NotFound();


            return View(skill);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, Skill skil)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (Id != skil.Id) return NotFound();

            Skill dbCategory = await _context.Skills.AsNoTracking().Where(m =>m.Id == Id).FirstOrDefaultAsync();

            if (dbCategory.Name.ToLower().Trim() == skil.Name.ToLower().Trim())
            {
                return RedirectToAction(nameof(Index));
            }

            bool isExist = _context.Skills.Any(m => m.Name.ToLower().Trim() == skil.Name.ToLower().Trim());
            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu Skill artiq movcuddur");
                return View();
            }

            //dbCategory.Name = category.Name;
            _context.Update(skil);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Id)
        {
            Skill skill = await _context.Skills.Where(m => m.Id == Id).FirstOrDefaultAsync();

            if (skill == null) return NotFound();

            //category.IsDeleted = true;
            _context.Skills.Remove(skill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion





    }
}
