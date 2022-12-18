using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class Slider : BaseEntity
    {
        public string Image { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile SliderImgFile { get; set; }
    }
}
