using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class Event : BaseEntity
    {
        public string Image { get; set; }
        public DateTime Date { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public string Description { get; set; }
        [StringLength(255)]
        public string StartTime { get; set; }
        [StringLength(255)]
        public string FinishTime { get; set; }
        [StringLength(255)]
        public string Venue { get; set; }
        [NotMapped]
        public List<int> EventIds { get; set; }
        public List<EventSpeaker> EventSpeakers { get; set; }
    }
}
