using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class Teacher : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string SurName { get; set; }
        public string Image { get; set; }
        public string AboutMe { get; set; }
        [StringLength(255)]
        public string Degree { get; set; }
        [StringLength(255)]
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        [NotMapped]
        public List<int> PositionIds { get; set; }
        public List<TeacherPosition> TeacherPositions { get; set; }
        [NotMapped]
        public List<int> SkillIds { get; set; }
        public List<TeacherSkills> TeacherSkills { get; set; }
        [NotMapped]
        public List<int> HobbiesIds { get; set; }
        public List<TeacherHobbies> TeacherHobbies { get; set; }



    }
}
