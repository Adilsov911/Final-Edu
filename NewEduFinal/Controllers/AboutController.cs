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
                Abouts = _context.Abouts.Where(s => s.IsDeleted == false).FirstOrDefault(),
                Teachers = _context.Teachers.Include(p => p.TeacherPositions).ThenInclude(tp => tp.Position).Where(s => s.IsDeleted == false).ToList().Take(4).ToList(),
                NoticeBoards = _context.NoticeBoards.Where(s => s.IsDeleted == false).ToList(),
                Blogs = _context.Blogs.Where(s => s.IsDeleted == false).ToList().Take(3).ToList()

            };


            return View(homeVM);
        }
    }
}
