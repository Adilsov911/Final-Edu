using Microsoft.AspNetCore.Mvc;
using NewEduFinal.DAL;
using NewEduFinal.Models;
using NewEduFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext _context;
        public SearchController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Search(string search)
        {

            

           List<CourseListVM> courses = _context.Courses.Where(c => c.Name.ToLower().Contains(search.ToLower())).Select(x=> new CourseListVM {
               Id = x.Id,
               Title =x.Name,
               Image = x.Image
           }).ToList();

            //List<CourseListVM> courseListVMs = new List<CourseListVM>();

            //foreach (Course course in courses)
            //{
            //    CourseListVM courseListVM = new CourseListVM
            //    {
            //        Id = course.Id,
            //        Title =course.Name,
            //        Image = course.Image
            //    };
            //    courseListVMs.Add(courseListVM);
            //}

            return PartialView("_SearchPartialView", courses);
        }
    }
}
