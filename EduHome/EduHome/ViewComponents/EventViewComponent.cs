using EduHome.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class EventViewComponent:ViewComponent
    {

        //private readonly AppDbContext _context;
        //public EventViewComponent(AppDbContext context)
        //{
        //    _context = context;
        //}
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //List<Course> courses = await _context.Courses.ToListAsync();

            return (await Task.FromResult(View()));
        }

    }
}
