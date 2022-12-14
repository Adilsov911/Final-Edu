using NewEduFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.ViewModels
{
    public class BlogVM
    {
        public List<Tag> Tags { get; set; }
        public List<Category> Categories { get; set; }
        public Blog Blog { get; set; }
    }
}
