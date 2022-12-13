using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class TeacherSkills : BaseEntity 
    {
        public int? TeacherId { get; set; }
        public Teacher Teachers { get; set; }
        public int? SkillsId { get; set; }
        public Skill Skills { get; set; }
    }
}
