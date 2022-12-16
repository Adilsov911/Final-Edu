using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewEduFinal.DAL;
using NewEduFinal.Extension;
using NewEduFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Areas.Manage.Controllers
{
    [Area("manage")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CourseController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            //List<Course> courses = _context.Courses.Include(c => c.CourseFeatures).Where(c => c.IsDeleted == false).ToList();

            return View(_context.Courses.Include(c => c.CourseFeatures).Where(c => c.IsDeleted == false).ToList());
            //return View(_context.Categories.Where(b => b.IsDeleted == false).ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {

            ViewBag.Course = _context.Courses.Where(c => c.IsDeleted == false).ToList();

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Course course)
        {

            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.CourseFutures = _context.CourseFeatures.ToList();
            ViewBag.Tags = _context.Tags.ToList();

            if (!_context.Categories.Any(x => x.Id == course.CategoryId))
            {
                ModelState.AddModelError("CategoryId", "Xetaniz var!");
                return View();
            }
            //if (!_context.CourseTags.All(ct => ct.Id==Tag))
            //{
            //    ModelState.AddModelError("CategoryId", "Xetaniz var!");
            //    return View();
            //}

            if (!ModelState.IsValid)
            {
                return View();
            }
            course.CourseTags = new List<CourseTag>();
            if (course.Image != null)
            {
                if (!course.CourseImgFile.IsImage())
                {
                    ModelState.AddModelError("CourseImgFile", "Choose correct image format file");
                    return View();
                }
               
                if (!course.CourseImgFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("CourseImgFile", "File must be max 2mb");
                    return View();
                }
                course.Image = course.CourseImgFile.SaveImg(_env.WebRootPath, "assets/img/course");
            }



            if (course.TagIds != null)
            {
                foreach (var tagId in course.TagIds)
                {
                    CourseTag courseTag = new CourseTag
                    {
                        Courses = course,
                         TagsId = tagId
                    };
                    _context.CourseTags.Add(courseTag);
                }
            }
            _context.Courses.Add(course);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


    }
}
