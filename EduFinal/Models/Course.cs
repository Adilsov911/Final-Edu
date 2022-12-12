using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduFinal.Models
{
    public class Course
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
       
        public string Description { get; set; }
        public string About { get; set; }
        public string HowApply { get; set; }
        public string Certification { get; set; }
        public DateTime Starts { get; set; }
        public string Duration { get; set; }
        public string CalssDuration { get; set; }
        [StringLength(255)]
        public string SkillLevel { get; set; }
        [StringLength(255)]
        public string Language { get; set; }
        public string Students { get; set; }
        [StringLength(255)]
        public string Assesments { get; set; }
        public double Price { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public int? TagsId { get; set; }
        public Tags Tags { get; set; }
        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public string Img { get; set; }

    }
}
