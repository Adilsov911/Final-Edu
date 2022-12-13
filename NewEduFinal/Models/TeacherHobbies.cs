using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class TeacherHobbies : BaseEntity
    {
        public int? TeacherId { get; set; }
        public Teacher Teachers { get; set; }
        public int? HobbiesId { get; set; }
        public Hobbie Hobbies { get; set; }
    }
}
