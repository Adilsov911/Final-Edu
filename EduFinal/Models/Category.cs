﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduFinal.Models
{
    public class Category 
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
    }
}
