using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduFinal.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string SurName { get; set; }
        [StringLength(255)]
        public string Position { get; set; }
        
        public string About { get; set; }
        [StringLength(255)]
        public string Degree { get; set; }
        [StringLength(255)] 
        public string Experince { get; set; }
        [StringLength(255)]
        public string Hobbies { get; set; }
        [StringLength(255)]
        public string Faculty { get; set; }
        [StringLength(255)]
        public string Mail { get; set; }
        public string Img { get; set; }
        [StringLength(255)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Skype { get; set; }

        public int? SkillsId { get; set; }
        public Skills Skills { get; set; }
    }
}
