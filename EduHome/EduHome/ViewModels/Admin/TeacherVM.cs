using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Admin
{
    public class TeacherVM
    {
        public IFormFile Image { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string About { get; set; }
        public string Degree { get; set; }
        public int Experience { get; set; }
        public string Faculty { get; set; }
        public string Mail { get; set; }
        public int Number { get; set; }
        public string Skype { get; set; }
        public List<SelectListItem> SelectSkills { get; set; }

         public List<SelectListItem> drpSubjects { get; set; }  
  
        [Display(Name="Subjects")]  
        public long[] SubjectsIds { get; set; } 
    }
}
