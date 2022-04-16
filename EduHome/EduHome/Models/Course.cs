using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Course
    {
        public int Id { get; set; }
       
        public string Image { get; set; }
      
        public string Name { get; set; }
        public string Desc { get; set; }
      
        public string AboutDesc { get; set; }
      
        public string ApplyDesc { get; set; }
   
        public string CertificationDesc { get; set; }
        public int CourseFutureId { get; set; }
        public CourseFuture CourseFuture { get; set; }
        public string UserId { get; set; }


    }
}
