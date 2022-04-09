using EduHome.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Admin
{
    public class CourseVM
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public string AboutDesc { get; set; }

        public string ApplyDesc { get; set; }

        public string CertificationDesc { get; set; }
        public string DetailName { get; set; }

        public DateTime Datatime { get; set; }
        public string Duration { get; set; }

        public string ClassDuration { get; set; }
        public string SkillsLevel { get; set; }
        public string Language { get; set; }
        public int Students { get; set; }
        public string Assestmens { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

    }
}
