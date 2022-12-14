using NewEduFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.ViewModels
{
    public class TeacherVM
    {
        public List<Category> Categories { get; set; }
        public List<CourseTag> CourseTags { get; set; }
        public Teacher Teacher { get; set; }
        public List<TeacherSkills> Skills { get; set; }
        public List<TeacherHobbies> TeacherHobbies  { get; set; }
    }
}
