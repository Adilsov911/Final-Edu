using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduFinal.Models
{
    public class Board
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        
        public string Description { get; set; }
    }
}
