using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class About : BaseEntity
    {
        [StringLength(255)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
