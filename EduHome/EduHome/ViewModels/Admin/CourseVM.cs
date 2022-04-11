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

        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [StringLength(50, ErrorMessage = "Uzunluq cox ola bilmez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(10, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string Desc { get; set; }

        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(10, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string AboutDesc { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(10, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string ApplyDesc { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(10, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string CertificationDesc { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(5, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string DetailName { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        
        public DateTime Datatime { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        public string Duration { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(10, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string ClassDuration { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(10, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string SkillsLevel { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [StringLength(25, ErrorMessage = "Uzunluq cox ola bilmez")]
        public string Language { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        public int Students { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(5, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string Assestmens { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

    }
}
