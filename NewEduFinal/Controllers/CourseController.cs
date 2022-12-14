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
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        public CourseController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Abouts = _context.Abouts.Where(s => s.IsDeleted == false).FirstOrDefault(),
                Teachers = _context.Teachers.Include(p => p.TeacherPositions).ThenInclude(tp => tp.Position).Where(s => s.IsDeleted == false).ToList().Take(4).ToList(),
                NoticeBoards = _context.NoticeBoards.Where(s => s.IsDeleted == false).ToList(),
                Blogs = _context.Blogs.Where(s => s.IsDeleted == false).Take(3).ToList(),
                Courses = _context.Courses.Where(s => s.IsDeleted == false).ToList().Take(9).ToList()
            };


            return View(homeVM);
        }
        public IActionResult Detail(int id)
        {
            CourseVM courseVM = new CourseVM()
            {

                Teachers = _context.Teachers.Include(p => p.TeacherPositions).ThenInclude(tp => tp.Position).Where(s => s.IsDeleted == false).ToList().Take(4).ToList(),
                Courses = _context.Courses.Include(c => c.CourseFeatures).Include(c => c.CourseTags).ThenInclude(ct => ct.Tags).FirstOrDefault(c => c.Id == id),
                CourseFeatures = _context.CourseFeatures.Include(cf => cf.Courses).Where(cf => cf.CoursesId == id).Where(s => s.IsDeleted == false).ToList(),
                Categories = _context.Categories.Where(s => s.IsDeleted == false).ToList()

            };


            return View(courseVM);
        }

    }
}
