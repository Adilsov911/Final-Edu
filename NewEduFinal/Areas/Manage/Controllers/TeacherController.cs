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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public TeacherController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            
            List<Teacher> teachers = _context.Teachers.Include(t => t.TeacherSkills).ThenInclude(c=>c.Skills).Include(t => t.TeacherPositions).ThenInclude(tp => tp.Position).ToList();

            return View(teachers);
        }
        public IActionResult Create()
        {
            ViewBag.Hobbies = _context.Hobbies.ToList();
            ViewBag.Positions = _context.Positions.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Teacher teacher)
        {
            ViewBag.Hobbies = _context.Hobbies.ToList();
            ViewBag.Positions = _context.Positions.ToList();


            //if (!_context.socialmedias.any(x => x.id == teacher.socialids))
            //{
            //    modelstate.addmodelerror("categoryid", "xetaniz var!");
            //    return view();
            //}
            //if (!_context.CourseTags.All(ct => ct.Id==Tag))
            //{
            //    ModelState.AddModelError("CategoryId", "Xetaniz var!");
            //    return View();
            //}

            if (!ModelState.IsValid)
            {
                return View();
            }
            teacher.TeacherPositions = new List<TeacherPosition>();
            teacher.TeacherHobbies = new List<TeacherHobbies>();

            
            //teacher.SocialMedias = new List<SocialMedia>();

            if (teacher.TeacherImgFile != null)
            {
                if (!teacher.TeacherImgFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct image format file");
                    return View();
                }
                if (!teacher.TeacherImgFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View();
                }
                teacher.Image = teacher.TeacherImgFile.SaveImg(_env.WebRootPath, "assets/img/teacher");
            }



            if (teacher.TeacherHobbies != null)
            {
                foreach (var hobbieId in teacher.HobbiesIds)
                {
                    TeacherHobbies teacherHobbie = new TeacherHobbies
                    {
                        Teachers = teacher,
                        HobbiesId = hobbieId
                    };
                    _context.TeacherHobbies.Add(teacherHobbie);
                }
            }
           
            if (teacher.PositionIds != null)
            {
                foreach (var positionId in teacher.PositionIds)
                {
                    TeacherPosition teacherPosition = new TeacherPosition
                    {
                        Teacher = teacher,
                        PositionId = positionId
                    };
                    _context.TeacherPositions.Add(teacherPosition);
                }
            }

            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
