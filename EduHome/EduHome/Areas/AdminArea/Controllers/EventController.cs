using EduHome.Data;
using EduHome.Models;
using EduHome.Utilities.File;
using EduHome.Utilities.Helpers;
using EduHome.ViewModels.Admin;
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
    [Authorize(Roles = "Admin")]
    public class EventController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public EventController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }


        #region Index
        public async Task<IActionResult> Index()
        {
            List<Event> events = await _context.Events.ToListAsync();
            return View(events);
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int id)
        {
            Event events = await _context.Events.Where(m => m.Id == id).Include(m => m.EventsDetail).FirstOrDefaultAsync();

            return View(events);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventVM eventVM)
        {

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();

            if (ModelState["DPhoto"].ValidationState == ModelValidationState.Invalid) return View();



            if (!eventVM.DPhoto.CheckFileType("image/"))
            {
                ModelState.AddModelError("DPhoto", "Image type is wrong");
                return View();
            }

            if (!eventVM.DPhoto.CheckFileSize(10000))
            {
                ModelState.AddModelError("DPhoto", "Image size is wrong");
                return View();
            }
            string fileDetail = Guid.NewGuid().ToString() + "_" + eventVM.DPhoto.FileName;

            string pathDetail = Helper.GetFilePath(_env.WebRootPath, "assets/img/event", fileDetail);
            using (FileStream stream = new FileStream(pathDetail, FileMode.Create))
            {
                await eventVM.Photo.CopyToAsync(stream);
            }

            EventDetail eventDetail = new EventDetail
            {
                DetailImage = fileDetail,
                Name = eventVM.Name,
                Desc = eventVM.Desc,
            };
            await _context.EventDetails.AddAsync(eventDetail);
            await _context.SaveChangesAsync();
            List<EventDetail> levents = await _context.EventDetails.ToListAsync();

            if (!eventVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View();
            }

            if (!eventVM.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View();
            }



















            string fileName = Guid.NewGuid().ToString() + "_" + eventVM.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/event", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await eventVM.Photo.CopyToAsync(stream);
            }
            Event events = new Event
            {
                Image = fileName,
                Date = eventVM.Date,
                Header = eventVM.Header,
                Time = eventVM.Time,
                Location = eventVM.Location,
                EventDetailId = levents.LastOrDefault().Id
            };
            await _context.Events.AddAsync(events);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Event levent = await _context.Events.Where(m => m.Id == id).Include(m => m.EventsDetail).FirstOrDefaultAsync();

            if (levent == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/event", levent.Image);

            Helper.DeleteFile(path);

            string pathDetail = Helper.GetFilePath(_env.WebRootPath, "assets/img/event", levent.EventsDetail.DetailImage);
            Helper.DeleteFile(pathDetail);

            _context.Events.Remove(levent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Edit





        public async Task<IActionResult> Edit(int Id)
        {
            var levent = await GetEventById(Id);
            EventVM eventVM = new EventVM
            {
                Image = levent.Image,
                Date = levent.Date,
                Header = levent.Header,
                Time = levent.Time,
                Location = levent.Location,
                DetailImage = levent.EventsDetail.DetailImage,
                Name = levent.EventsDetail.Name,
                Desc = levent.EventsDetail.Desc,

            };
            if (eventVM == null) return NotFound();
            return View(eventVM);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int Id, EventVM eventVM)
        //{
        //    var dbEvents = await GetEventById(Id);
        //    if (dbEvents == null) return NotFound();

        //    if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();

        //    if (!eventVM.Photo.CheckFileType("image/"))
        //    {
        //        ModelState.AddModelError("Photo", "Image type is wrong");
        //        return View(dbEvents);
        //    }

        //    if (!eventVM.Photo.CheckFileSize(800))
        //    {
        //        ModelState.AddModelError("Photo", "Image size is wrong");
        //        return View(dbEvents);
        //    }

        //    string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/event", dbEvents.Image);

        //    Helper.DeleteFile(path);
        //    if (ModelState["DPhoto"].ValidationState == ModelValidationState.Invalid) return View();

        //    if (!eventVM.DPhoto.CheckFileType("image/"))
        //    {
        //        ModelState.AddModelError("DPhoto", "Image type is wrong");
        //        return View(dbEvents);
        //    }

        //    if (!eventVM.DPhoto.CheckFileSize(800))
        //    {
        //        ModelState.AddModelError("DPhoto", "Image size is wrong");
        //        return View(dbEvents);
        //    }

        //    string pathDetail = Helper.GetFilePath(_env.WebRootPath, "assets/img/event", dbEvents.EventsDetail.DetailImage);

        //    Helper.DeleteFile(pathDetail);


        //    string fileName = Guid.NewGuid().ToString() + "_" + eventVM.Photo.FileName;

        //    string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/event", fileName);

        //    using (FileStream stream = new FileStream(newPath, FileMode.Create))
        //    {
        //        await eventVM.Photo.CopyToAsync(stream);
        //    }

        //    string fileDetail = Guid.NewGuid().ToString() + "_" + eventVM.DPhoto.FileName;

        //    string newPathD = Helper.GetFilePath(_env.WebRootPath, "assets/img/event", fileDetail);

        //    using (FileStream stream = new FileStream(newPathD, FileMode.Create))
        //    {
        //        await eventVM.DPhoto.CopyToAsync(stream);
        //    }

        //    dbEvents.Image = fileName;
        //    dbEvents.Date = eventVM.Date;
        //    dbEvents.Header = eventVM.Header;
        //    dbEvents.Time = eventVM.Time;
        //    dbEvents.Location = eventVM.Location;
        //    dbEvents.EventsDetail.DetailImage = fileDetail;
        //    dbEvents.EventsDetail.Name = eventVM.Name;
        //    dbEvents.EventsDetail.Desc = eventVM.Desc;





        //    await _context.SaveChangesAsync();

        //    return RedirectToAction(nameof(Index));
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, EventVM eventVM)
        {
            var dbEvents = await GetEventById(Id);
            if (dbEvents == null) return NotFound();

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();

            if (!eventVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View(dbEvents);
            }

            if (!eventVM.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View(dbEvents);
            }
            if (ModelState["DPhoto"].ValidationState == ModelValidationState.Invalid) return View();

            if (!eventVM.DPhoto.CheckFileType("image/"))
            {
                ModelState.AddModelError("DPhoto", "Image type is wrong");
                return View(dbEvents);
            }

            if (!eventVM.DPhoto.CheckFileSize(10000))
            {
                ModelState.AddModelError("DPhoto", "Image size is wrong");
                return View(dbEvents);
            }

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/event", dbEvents.Image);
            Helper.DeleteFile(path);

            string pathDetail = Helper.GetFilePath(_env.WebRootPath, "assets/img/event", dbEvents.EventsDetail.DetailImage);
            Helper.DeleteFile(pathDetail);

            string fileName = Guid.NewGuid().ToString() + "_" + eventVM.Photo.FileName;
            path = Helper.GetFilePath(_env.WebRootPath, "assets/img/event", fileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await eventVM.Photo.CopyToAsync(stream);
            }
            dbEvents.Image = fileName;
            fileName = Guid.NewGuid().ToString() + "_" + eventVM.DPhoto.FileName;
            path = Helper.GetFilePath(_env.WebRootPath, "assets/img/event", fileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await eventVM.DPhoto.CopyToAsync(stream);
            }
            dbEvents.EventsDetail.DetailImage = fileName;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }





        #endregion

        #region Helper
        private async Task<Event> GetEventById(int Id)
        {
            return await _context.Events.Where(m => m.Id == Id).Include(m => m.EventsDetail).FirstOrDefaultAsync();
        }
        #endregion


    }
}
