using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class Course : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string HowToApply { get; set; }
        public string AboutCourseInfo { get; set; }
        public string CertificationInfo { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
