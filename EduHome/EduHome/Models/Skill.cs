using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Skill:BaseEntity
    {
       
        public string Name { get; set; }
        public List<TeacherSkill> Teachers { get; set; }

        internal dynamic skillList()
        {
            throw new NotImplementedException();
        }

        internal static object ToList()
        {
            throw new NotImplementedException();
        }
    }
}
