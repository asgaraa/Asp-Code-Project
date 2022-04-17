using EduHome.Data;
using EduHome.Models;
using EduHome.Utilities.File;
using EduHome.Utilities.Helpers;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles ="Admin")]
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public AboutController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        #region Index
        public IActionResult Index()
        {
            About about = _context.Abouts.FirstOrDefault();
            return View(about);

        }
        #endregion

        #region Edit
        public async Task<IActionResult> Edit(int Id)
        {
            About about = await GetAboutById(Id);
            if (about == null) return NotFound();
            return View(about);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, About about)
        {
            var dbPoster = await GetAboutById(Id);
            if (dbPoster == null) return NotFound();

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();

            if (!about.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View(dbPoster);
            }

            if (!about.Photo.CheckFileSize(800))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View(dbPoster);
            }

            string path = Helper.GetFilePath(_env.WebRootPath, "Assets/img/about", dbPoster.Image);

            Helper.DeleteFile(path);


            string fileName = Guid.NewGuid().ToString() + "_" + about.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "Assets/img/about", fileName);

            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await about.Photo.CopyToAsync(stream);
            }

            dbPoster.Image = fileName;
            dbPoster.Header = about.Header;
            dbPoster.HeadDesc = about.HeadDesc;
            dbPoster.Description = about.Description;
            dbPoster.DescriptSecond = about.DescriptSecond;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Helper
        private async Task<About> GetAboutById(int Id)
        {
            return await _context.Abouts.FindAsync(Id);
        }
        #endregion



    }
}
