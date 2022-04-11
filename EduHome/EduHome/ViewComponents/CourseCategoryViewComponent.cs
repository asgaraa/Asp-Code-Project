using EduHome.Data;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class CourseCategoryViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public CourseCategoryViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Course> courses = await _context.Courses.Take(take).ToListAsync();

            return (await Task.FromResult(View(courses)));
        }
    }
}
