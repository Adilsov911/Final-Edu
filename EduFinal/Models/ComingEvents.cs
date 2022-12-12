using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduFinal.Models
{
    public class ComingEvents
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Location { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Img { get; set; }
        [StringLength(255)]
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        [StringLength(255)]
        public string Venue { get; set; }
        
        public string Description { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }


    }
}
