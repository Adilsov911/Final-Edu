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
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Abouts = _context.Abouts.FirstOrDefault(),
                Teachers = _context.Teachers.Include(p => p.TeacherPositions).ThenInclude(tp => tp.Position).ToList().Take(4).ToList(),
                NoticeBoards = _context.NoticeBoards.ToList(),
                Blogs = _context.Blogs.ToList().Take(3).ToList()

            };


            return View(homeVM);
        }
    }
}
