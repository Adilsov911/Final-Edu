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
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [StringLength(255)]
        public string AuthorName { get; set; }
        [StringLength(255)]
        public string AuthorSurname { get; set; }
    }
}
