using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public List<TeacherSkill> Teachers { get; set; }
    }
}
