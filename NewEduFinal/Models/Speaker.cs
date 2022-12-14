using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class Speaker : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Surname { get; set; }
        public string Image { get; set; }
        public string Position { get; set; }
        [NotMapped]
        public List<int> EventIds { get; set; }
        public List<EventSpeaker> EventSpeakers { get; set; }


    }
}
