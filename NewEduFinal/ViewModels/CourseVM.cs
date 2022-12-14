using NewEduFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.ViewModels
{
    public class CourseVM
    {
       
        public Course Courses { get; set; }
        public List<Setting> Settings { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Category> Categories { get; set; }

        public Speaker Speaker { get; set; }
        public List<Event> Events { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<CourseFeatures> CourseFeatures { get; set; }

    }
}
