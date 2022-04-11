using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Admin
{
    public class EventVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(10, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(10, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string Date { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(10, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string Header { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(10, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string Time { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(6, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        public string DetailImage { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(5, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(10, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string Desc { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

        [NotMapped]
        [Required]
        public IFormFile DPhoto { get; set; }
    }
}
