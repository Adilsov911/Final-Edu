using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class TeacherPosition : BaseEntity
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
