using EduHome.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewComponents
{
    public class HeaderViewComponent: ViewComponent
    {
        //private readonly AppDbContext _context;
        //public HeaderViewComponent(AppDbContext context)
        //{
        //    _context = context;
        //}

        public async Task<IViewComponentResult> InvokeAsync()
        {


            return (await Task.FromResult(View()));
        }
    }
}
