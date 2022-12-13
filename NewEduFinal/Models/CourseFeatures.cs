using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class CourseFeatures : BaseEntity
    {
        public DateTime StartTime { get; set; }
        [StringLength(255)]
        public string Duration { get; set; }
        [StringLength(255)]
        public string ClassDuration { get; set; }
        [StringLength(255)]
        public string SkillLevel { get; set; }
        [StringLength(255)]
        public string Language { get; set; }
        [StringLength(255)]
        public string Assesments { get; set; }
        public double Price { get; set; }
        public int StudentCount { get; set; }
        public int CoursesId { get; set; }
        public Course Courses { get; set; }
    }
}
