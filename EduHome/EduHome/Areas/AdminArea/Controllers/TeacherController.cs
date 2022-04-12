using EduHome.Data;
using EduHome.Models;
using EduHome.Utilities.File;
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
    public class TeacherController : Controller
    {
       
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public TeacherController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Teacher> teachers = await _context.Teachers.ToListAsync();
            return View(teachers);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeacherVM teacherVM)
        {

            if (ModelState.IsValid) return View(teacherVM);

           



            if (!teacherVM.Image.CheckFileType("image/"))
            {
                ModelState.AddModelError("Image", "Image type is wrong");
                return View();
            }

            if (!teacherVM.Image.CheckFileSize(10000))
            {
                ModelState.AddModelError("Image", "Image size is wrong");
                return View();
            }
            string fileName = Guid.NewGuid().ToString() + "_" + teacherVM.Image.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/teacher", fileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await teacherVM.Image.CopyToAsync(stream);
            }


           



            Teacher teacher = new Teacher
            {
                Image = fileName,
                Name = teacherVM.Name,
                Position = teacherVM.Position,
                About = teacherVM.About,
                Degree = teacherVM.Degree,
                Experience = teacherVM.Experience,
                Faculty = teacherVM.Faculty,
                Mail = teacherVM.Mail,
                Number = teacherVM.Number,
                Skype = teacherVM.Skype,

                
            };
            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();
           
          
            return RedirectToAction(nameof(Index));
        }

       
        #endregion

    }
}
