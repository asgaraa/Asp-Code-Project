using EduHome.Data;
using EduHome.Models;
using EduHome.Utilities.File;
using EduHome.Utilities.Helpers;
using EduHome.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EduHome.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles ="Admin,Moderator")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly SignInManager<AppUser> _signInManager;
        public CourseController(AppDbContext context, IWebHostEnvironment env, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _env = env;
            _signInManager = signInManager;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            var AdminId = this.User.FindFirstValue(ClaimTypes.NameIdentifier).ToString();
            List<Course> courseDetails = new List<Course> { };
           
            if (AdminId == "376fc97b-d927-4605-8685-1ef2c94fc33a")
            {
                courseDetails = await _context.Courses.ToListAsync();

            }
            else
            {
                courseDetails = await _context.Courses.Where(m => m.UserId == this.User.FindFirstValue(ClaimTypes.NameIdentifier)).ToListAsync();
            }

            return View(courseDetails);
        }
        #endregion


        #region Detail
        public async Task<IActionResult> Detail(int id)
        {
            Course course = await _context.Courses.Where(m => m.Id == id).Include(m => m.CourseFuture).FirstOrDefaultAsync();

            return View(course);
        }
        #endregion

        #region Edit





        public async Task<IActionResult> Edit(int Id)
        {
            Course course = await _context.Courses.Where(m => m.Id == Id).Include(m => m.CourseFuture).FirstOrDefaultAsync();
            CourseVM courseVM = new CourseVM
            {
                Image = course.Image,
                Name = course.Name,
                Desc = course.Desc,
                AboutDesc = course.AboutDesc,
                ApplyDesc = course.ApplyDesc,
                CertificationDesc = course.CertificationDesc,
                DetailName = course.CourseFuture.Name,
                Datatime = course.CourseFuture.Datatime,
                Duration = course.CourseFuture.Duration,
                ClassDuration = course.CourseFuture.ClassDuration,
                SkillsLevel = course.CourseFuture.SkillsLevel,
                Language = course.CourseFuture.Language,
                Students = course.CourseFuture.Students,
                Assestmens = course.CourseFuture.Assestmens,
            };
            if (courseVM == null) return NotFound();
            return View(courseVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, CourseVM courseVM)
        {
            var dbCourse = await GetCourseById(Id);
            if (dbCourse == null) return NotFound();

            //if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();
            if (!ModelState.IsValid) return View();

            if (!courseVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View(dbCourse);
            }

            if (!courseVM.Photo.CheckFileSize(800))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View(dbCourse);
            }

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/course", dbCourse.Image);

            Helper.DeleteFile(path);


            string fileName = Guid.NewGuid().ToString() + "_" + courseVM.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/course", fileName);

            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await courseVM.Photo.CopyToAsync(stream);
            }

            dbCourse.Image = fileName;
            dbCourse.Name = courseVM.Name;
            dbCourse.Desc = courseVM.Desc;
            dbCourse.AboutDesc = courseVM.AboutDesc;
            dbCourse.ApplyDesc = courseVM.ApplyDesc;
            dbCourse.CertificationDesc = courseVM.CertificationDesc;
            dbCourse.CourseFuture.Name = courseVM.DetailName;
            dbCourse.CourseFuture.Datatime = courseVM.Datatime;
            dbCourse.CourseFuture.Duration = courseVM.Duration;
            dbCourse.CourseFuture.ClassDuration = courseVM.ClassDuration;
            dbCourse.CourseFuture.SkillsLevel = courseVM.SkillsLevel;
            dbCourse.CourseFuture.Language = courseVM.Language;
            dbCourse.CourseFuture.Students = courseVM.Students;
            dbCourse.CourseFuture.Assestmens = courseVM.Assestmens;



            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }




        #endregion


        #region Create
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseVM courseVM)
        {

            if (!ModelState.IsValid) return View();


            if (!courseVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View();
            }

            if (!courseVM.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View();
            }




            string fileName = Guid.NewGuid().ToString() + "_" + courseVM.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/course", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await courseVM.Photo.CopyToAsync(stream);
            }
            CourseFuture courseFuture = new CourseFuture
            {
                Name = courseVM.DetailName,
                Datatime = courseVM.Datatime,
                Duration = courseVM.Duration,
                ClassDuration = courseVM.ClassDuration,
                SkillsLevel = courseVM.SkillsLevel,
                Language = courseVM.Language,
                Students = courseVM.Students,
                Assestmens = courseVM.Assestmens
            };
            await _context.CourseFutures.AddAsync(courseFuture);
            await _context.SaveChangesAsync();
            List<CourseFuture> courseFutures = await _context.CourseFutures.ToListAsync();
            Course course = new Course
            {
                Image = fileName,
                Name = courseVM.Name,
                Desc = courseVM.Desc,
                AboutDesc = courseVM.AboutDesc,
                ApplyDesc = courseVM.ApplyDesc,
                CertificationDesc = courseVM.CertificationDesc,
                CourseFutureId = courseFutures.LastOrDefault().Id,
                UserId= this.User.FindFirstValue(ClaimTypes.NameIdentifier)

            };
            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();










            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Course course = await _context.Courses.FindAsync(id);

            if (course == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/course", course.Image);

            Helper.DeleteFile(path);

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Helper
        private async Task<Course> GetCourseById(int Id)
        {
            return await _context.Courses.Where(m => m.Id == Id).Include(m => m.CourseFuture).FirstOrDefaultAsync();
        }
        #endregion

        #region Logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Logout), "Course");
        }
        #endregion


    }
}
