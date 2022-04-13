﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Skill:BaseEntity
    {
       
        public string Name { get; set; }
        [NotMapped]
        public bool IsSelected { get; set; }
        public List<TeacherSkill> Teachers { get; set; }

      
    }
}
