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
    public class ServiceViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public ServiceViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            List<Service> service = await _context.Services.ToListAsync();
            return (await Task.FromResult(View(service)));
        }
    }
}
