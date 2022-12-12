using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduFinal.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        
        public string Description { get; set; }
       
        public string Img { get; set; }

    }
}
