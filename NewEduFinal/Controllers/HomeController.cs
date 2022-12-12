using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewEduFinal.DAL;
using NewEduFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Sliders = _context.Sliders.ToList(),
                Settings = _context.Settings.ToList(),
                Courses = _context.Courses.Include(c => c.CourseFeatures).Include(c => c.CourseTags).ThenInclude(ct => ct.Tags).Include(c => c.Category).Take(3).ToList(),
                Teachers = _context.Teachers.Include(e => e.Name).ToList(),
                NoticeBoards = _context.NoticeBoards.ToList(),
                
            };


            return View(homeVM);

        }
    }
}
