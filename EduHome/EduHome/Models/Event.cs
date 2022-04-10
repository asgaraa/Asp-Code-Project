using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Date { get; set; }
        public string Header { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public int EventDetailId { get; set; }
        public EventDetail EventsDetail { get; set; }

    }
}
