using EduHome.Data;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        public CourseController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Detail(int id)
        {
            Course course = await _context.Courses.Where(m => m.Id == id).Include(m => m.CourseFuture).FirstOrDefaultAsync();
            return View(course);
        }
        public async Task<IActionResult> Search(string search)
        {
            List<Course> courses = await _context.Courses.ToListAsync();

            List<Course> searchedCourses = new List<Course> { };

            foreach (var course in courses)
            {
                if (course.Name.ToLower().Contains(search.ToLower()))
                {
                    searchedCourses.Add(course);
                }
            }
            return View(searchedCourses);
        }
    }
}
