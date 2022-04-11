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
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Event> levent = await _context.Events.Include(m => m.EventsDetail).ToListAsync();
            return View(levent);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Event levent = await _context.Events.Where(m => m.Id == id).Include(m => m.EventsDetail).FirstOrDefaultAsync();
            return View(levent);
        }
    }
}
