using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduFinal.Models
{
    public class About
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Img { get; set; }
        
        public string Description { get; set; }
    }
}
