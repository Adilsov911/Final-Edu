using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewEduFinal.DAL;
using NewEduFinal.Models;
using NewEduFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            CourseVM courseVM = new CourseVM()
            {

                Teachers = _context.Teachers.Include(p => p.TeacherPositions).ThenInclude(tp => tp.Position).Where(s => s.IsDeleted == false).Take(12).ToList(),
                Categories = _context.Categories.Where(s => s.IsDeleted == false).ToList()

            };
            return View(courseVM);
        }
        public IActionResult Detail(int id)
        {
            TeacherVM teacherVM = new TeacherVM()
            {

                Teacher = _context.Teachers.Include(p => p.TeacherPositions).ThenInclude(tp => tp.Position).Include(s => s.TeacherSkills).ThenInclude(z => z.Skills).Include(e=>e.TeacherHobbies).ThenInclude(d=>d.Hobbies).Where(s => s.IsDeleted == false).FirstOrDefault(p => p.Id == id)
            };
            return View(teacherVM);
        }
    }
}
