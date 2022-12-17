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

        public IActionResult Update(int id)
        {
            ViewBag.Hobbies = _context.Hobbies.ToList();
            ViewBag.Positions = _context.Positions.ToList();
            Teacher teacher = _context.Teachers.Include(t => t.TeacherHobbies).ThenInclude(th => th.Hobbies).Include(t => t.TeacherPositions).ThenInclude(tp => tp.Position).FirstOrDefault(x => x.Id == id);
            if (teacher == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(teacher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Teacher teacher)
        {
            ViewBag.Hobbies = _context.Hobbies.ToList();
            ViewBag.Positions = _context.Positions.ToList();

            Teacher existTeacher = _context.Teachers.Include(t => t.TeacherHobbies).ThenInclude(th => th.Hobbies).Include(t => t.TeacherPositions).ThenInclude(tp => tp.Position).FirstOrDefault(x => x.Id == id);
            
            if (existTeacher == null)
            {
                return RedirectToAction(nameof(Index));
            }
            if (teacher.TeacherImgFile != null)
            {
                if (!teacher.TeacherImgFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct format file");
                    return View();
                }
                if (!teacher.TeacherImgFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View();
                }
                existTeacher.Image = teacher.TeacherImgFile.SaveImg(_env.WebRootPath, "assets/img/teacher");


            }

            if (!ModelState.IsValid)
            {
                return View();
            }
            

            var existHobbies = _context.TeacherHobbies.Where(x => x.TeacherId == id).ToList();
            if (teacher.HobbiesIds != null)
            {
                foreach (var hobbieId in teacher.HobbiesIds)
                {
                    var existHobbie = existHobbies.FirstOrDefault(x => x.HobbiesId == hobbieId);
                    if (existHobbie == null)
                    {
                        TeacherHobbies teacherHobbie = new TeacherHobbies
                        {
                            TeacherId = id,
                            HobbiesId = hobbieId,
                        };

                        _context.TeacherHobbies.Add(teacherHobbie);
                    }
                    else
                    {
                        existHobbies.Remove(existHobbie);
                    }
                }

            }
            _context.TeacherHobbies.RemoveRange(existHobbies);

            var existPositions = _context.TeacherPositions.Where(x => x.TeacherId == id).ToList();
            if (teacher.PositionIds != null)
            {
                foreach (var positionId in teacher.PositionIds)
                {
                    var existPosition = existPositions.FirstOrDefault(x => x.PositionId == positionId);
                    if (existPosition == null)
                    {
                        TeacherPosition teacherPosition = new TeacherPosition
                        {
                            TeacherId = id,
                            PositionId = positionId,
                        };

                        _context.TeacherPositions.Add(teacherPosition);
                    }
                    else
                    {
                        existPositions.Remove(existPosition);
                    }
                }

            }

            _context.TeacherPositions.RemoveRange(existPositions);
            existTeacher.Image = teacher.Image;
            existTeacher.Name = teacher.Name.Trim();
            existTeacher.AboutMe = teacher.AboutMe;
            existTeacher.Degree = teacher.Degree;
            existTeacher.SurName = teacher.SurName.Trim();
            existTeacher.PhoneNumber = teacher.PhoneNumber;
            existTeacher.Mail = teacher.Mail;
            existTeacher.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existTeacher.UpdatedBy = "System";

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));


        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

                Teacher teacher = _context.Teachers.Include(t => t.TeacherHobbies).ThenInclude(th => th.Hobbies).Include(t => t.TeacherPositions).ThenInclude(tp => tp.Position).FirstOrDefault(hs => hs.Id == id);
                Teacher existTeacher = _context.Teachers.Include(t => t.TeacherHobbies).ThenInclude(th => th.Hobbies).Include(t => t.TeacherPositions).ThenInclude(tp => tp.Position).FirstOrDefault(s => s.Id == teacher.Id);

                if (existTeacher == null) return NotFound("id yanlisdir");
                if (teacher == null) return RedirectToAction("Index");
                _context.Teachers.Remove(teacher);
                _context.SaveChanges();

                return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest("id null ola bilmez");
            }

            Teacher teacher = _context.Teachers
                .Include(c => c.TeacherHobbies)
                .ThenInclude(c => c.Hobbies)
                .Include(c=>c.TeacherPositions)
                .ThenInclude(c=>c.Position)
                .FirstOrDefault(c => c.IsDeleted == false &&  c.Id == id);

            if (teacher == null)
            {
                return NotFound("id yalnisdir");
            }

            return View(teacher);
        }

    }
}
