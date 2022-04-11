using EduHome.Data;
using EduHome.Models;
using EduHome.Utilities.File;
using EduHome.Utilities.Helpers;
using EduHome.ViewModels.Admin;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class BlogController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Blog> blogs = await _context.Blogs.ToListAsync();
            return View(blogs);
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int id)
        {
            Blog blog = await _context.Blogs.FirstOrDefaultAsync();

            return View(blog);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {

            if (!ModelState.IsValid) return View();


            if (!blog.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View();
            }

            if (!blog.Photo.CheckFileSize(10000))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View();
            }




            string fileName = Guid.NewGuid().ToString() + "_" + blog.Photo.FileName;

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/blog", fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await blog.Photo.CopyToAsync(stream);
            }
            Blog blogs = new Blog
            {
                Image = fileName,
                Name = blog.Name,
                Author = blog.Author,
                Date = blog.Date,
                Desc = blog.Desc
               
            };
            await _context.Blogs.AddAsync(blogs);
            await _context.SaveChangesAsync();
        










            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Edit





        public async Task<IActionResult> Edit(int Id)
        {
            Blog blog = await _context.Blogs.FirstOrDefaultAsync();
            BlogVM blogVM = new BlogVM
            {
                Image = blog.Image,
                Name = blog.Name,
                Desc = blog.Desc,
                Date = blog.Date,
                Author = blog.Author,
               
            };
            if (blogVM == null) return NotFound();
            return View(blogVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, BlogVM blogVM)
        {
            var dbBlog = await GetBlogById(Id);
            if (dbBlog == null) return NotFound();

            //if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();
            if (!ModelState.IsValid) return View();

            if (!blogVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Image type is wrong");
                return View(dbBlog);
            }

            if (!blogVM.Photo.CheckFileSize(800))
            {
                ModelState.AddModelError("Photo", "Image size is wrong");
                return View(dbBlog);
            }

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/blog", dbBlog.Image);

            Helper.DeleteFile(path);


            string fileName = Guid.NewGuid().ToString() + "_" + blogVM.Photo.FileName;

            string newPath = Helper.GetFilePath(_env.WebRootPath, "assets/img/blog", fileName);

            using (FileStream stream = new FileStream(newPath, FileMode.Create))
            {
                await blogVM.Photo.CopyToAsync(stream);
            }

            dbBlog.Image = fileName;
            dbBlog.Name = blogVM.Name;
            dbBlog.Desc = blogVM.Desc;
            dbBlog.Author = blogVM.Author;
            dbBlog.Date = blogVM.Date;
          



            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }




        #endregion

        #region Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            Blog blog = await _context.Blogs.FindAsync(id);

            if (blog == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "assets/img/blog", blog.Image);

            Helper.DeleteFile(path);

            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Helper
        private async Task<Blog> GetBlogById(int Id)
        {
            return await _context.Blogs.FindAsync(Id);
        }
        #endregion

    }
}
