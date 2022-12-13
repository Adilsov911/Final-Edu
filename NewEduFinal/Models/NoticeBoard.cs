using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Models
{
    public class NoticeBoard :BaseEntity
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
