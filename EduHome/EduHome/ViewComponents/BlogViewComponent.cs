using EduHome.Data;
using EduHome.Models;
using EduHome.Utilities.Paginations;
using EduHome.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public BlogViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Blog> blogs = await _context.Blogs.Take(take).ToListAsync();

            return (await Task.FromResult(View(blogs)));
        }
    }
}
