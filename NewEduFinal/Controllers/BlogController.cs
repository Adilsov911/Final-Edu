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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Blogs = _context.Blogs.Where(s => s.IsDeleted == false).ToList(),
                Categories = _context.Categories.Where(s => s.IsDeleted == false).ToList()
            };


            return View(homeVM);
        }
        public IActionResult Detail(int id)
        {
            BlogVM blogVM = new BlogVM()
            { 
                Blog = _context.Blogs.Where(s => s.IsDeleted == false).FirstOrDefault(p => p.Id == id),
                Categories = _context.Categories.Where(s => s.IsDeleted == false).ToList(),
                Tags =_context.Tags.Where(s => s.IsDeleted == false).ToList()
            };
            return View(blogVM);
        }
    }
}
