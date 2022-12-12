using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class Hobbie : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
    }
}
