using NewEduFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.ViewModels
{
    public class EventVM
    {
        public List<Teacher> Teachers { get; set; }
        public List<Category> Categories { get; set; }
        public List<Speaker> Speaker { get; set; }
        public Event Events { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Speaker> Speakers { get; set; }
        public List<EventSpeaker> EventSpeakers { get; set; }

    }
}
