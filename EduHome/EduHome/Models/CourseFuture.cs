using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class CourseFuture
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
       
        public DateTime Datatime { get; set; }
        public string Duration { get; set; }

        public string ClassDuration { get; set; }
        public string SkillsLevel { get; set; }
        public string Language { get; set; }
        public int Students { get; set; }
        public string Assestmens { get; set; }


    }
}
