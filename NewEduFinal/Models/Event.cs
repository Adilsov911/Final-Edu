using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class Event : BaseEntity
    {
        public string Image { get; set; }
        public Nullable<DateTime> Date { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public string Description { get; set; }
        [StringLength(255)]
        public string StartTime { get; set; }
        [StringLength(255)]
        public string FinishTime { get; set; }
        [StringLength(255)]
        public string Venue { get; set; }

    }
}
