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
    public class EventController : Controller
    {
        
            private readonly AppDbContext _context;
            public EventController(AppDbContext context)
            {
                _context = context;
            }
            public IActionResult Index()
            {
                CourseVM courseVM = new CourseVM()
                {

                    Teachers = _context.Teachers.Include(p => p.TeacherPositions).ThenInclude(tp => tp.Position).ToList().Take(4).ToList(),
                    Speaker = _context.Speakers.FirstOrDefault(),
                    Events = _context.Events.Take(8).ToList(),
                    Categories = _context.Categories.ToList()

                };
                return View(courseVM);
            }
            public IActionResult Detail()
            {
                EventVM eventVM = new EventVM()
                {

                    Teachers = _context.Teachers.Include(p => p.TeacherPositions).ThenInclude(tp => tp.Position).ToList().Take(4).ToList(),
                    Speaker = _context.Speakers.Take(2).ToList(),
                    Events = _context.Events.FirstOrDefault(),
                    Categories = _context.Categories.ToList()

                };
                return View(eventVM);
        }
        
    }
}
