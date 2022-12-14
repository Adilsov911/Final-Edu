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

                    Teachers = _context.Teachers.Include(p => p.TeacherPositions).ThenInclude(tp => tp.Position).Where(s => s.IsDeleted == false).ToList().Take(4).ToList(),
                    Speaker = _context.Speakers.Where(s => s.IsDeleted == false).FirstOrDefault(),
                    Events = _context.Events.Where(s => s.IsDeleted == false).Take(9).ToList(),
                    Categories = _context.Categories.Where(s => s.IsDeleted == false).ToList()

                };
                return View(courseVM);
            }
            public IActionResult Detail(int id)
            {
                EventVM eventVM = new EventVM()
                {
                    Speakers = _context.Speakers.Include(s => s.EventSpeakers).Where(s=>s.IsDeleted == false).Where(s => s.Id == id).ToList(),
                    //Teachers = _context.Teachers.Include(p => p.TeacherPositions).ThenInclude(tp => tp.Position).ToList().Take(4).ToList(),
                    //EventSpeakers = _context.EventSpeakers.Include(es => es.Events).Include(es => es.Speakers).Where(es => es.EventsId == id).ToList(),
                    Events = _context.Events.Include(x => x.EventSpeakers).ThenInclude(es => es.Speakers).Where(x => x.IsDeleted == false).FirstOrDefault(x => x.Id == id),
                    Categories = _context.Categories.ToList()

                };
                return View(eventVM);
        }
        
    }
}
