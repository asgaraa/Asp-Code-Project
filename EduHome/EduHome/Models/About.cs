﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class About
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Header { get; set; }
        public string HeadDesc { get; set; }
        public string Description { get; set; }
        public string DescriptSecond { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

    }
}
