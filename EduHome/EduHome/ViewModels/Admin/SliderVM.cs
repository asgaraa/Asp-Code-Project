using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Admin
{
    public class SliderVM
    {

        public int Id { get; set; }

        [Required]
        public List<IFormFile> Photos { get; set; }
        public string Image { get; set; }
        public string Header { get; set; }
        public string Desc { get; set; }
    }
}
