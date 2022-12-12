using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class CourseTag : BaseEntity
    {
        public int CoursesId { get; set; }
        public Course Courses { get; set; }
        public int TagsId { get; set; }
        public Tag Tags { get; set; }
    }
}
