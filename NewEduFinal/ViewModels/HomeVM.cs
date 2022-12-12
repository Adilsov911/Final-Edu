using NewEduFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Course> Courses { get; set; }
        public List<Setting> Settings { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
    }
}
