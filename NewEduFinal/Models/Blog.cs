using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class Blog :BaseEntity
    {
        [StringLength(255)]
        public string Title { get; set; }
        public Nullable<DateTime> Date { get; set; }
        public string Description { get; set; }
    }
}
