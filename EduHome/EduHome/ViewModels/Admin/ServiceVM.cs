using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels.Admin
{
    public class ServiceVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(5, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string Header { get; set; }
        [Required(ErrorMessage = "Bu hisseni bosh buraxmayin")]
        [MinLength(5, ErrorMessage = "Məzmun qısa ola bilmez")]
        public string Desc { get; set; }
    }
}
