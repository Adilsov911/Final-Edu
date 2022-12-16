using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewEduFinal.DAL;
using NewEduFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Areas.Manage.Controllers
{
    [Area("manage")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.Categories.Where(b=>b.IsDeleted==false).ToList());
        }


        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.Where(c => c.IsDeleted == false).ToList();
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (_context.Categories.Any(c => c.IsDeleted == false && c.Name.ToLower() == category.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This Name = {category.Name} Already Exisist");
                return View(category);
            }
            category.Name = category.Name.Trim();
            category.IsDeleted = false;
            category.CreatedAt = DateTime.UtcNow.AddHours(4);
            category.CreatedBy = "System";

            _context.Categories.Add(category);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound("id yanlisdir");

            }
            Category category =_context.Categories
                .Include(c => c.courses)
                .FirstOrDefault(c => c.IsDeleted == false && c.Id == id);
            if (category == null)
            {
                return NotFound("id yalnisdir");
            }
            if (category.courses.Count() > 0)
            {
                return BadRequest("id yanlisdir");
            }

            category.IsDeleted = true;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id bos ola bilmez");
            }

            Category category =  _context.Categories.FirstOrDefault(c => c.IsDeleted == false && c.Id == id);

            if (category == null)
            {
                return NotFound("Daxil edilen Id yalnisdir");
            }

            ViewBag.Categories =_context.Categories.Where(c => c.IsDeleted == false).ToList();
            return View(category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int? id, Category category)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }



            ViewBag.Categories =_context.Categories.Where(c => c.IsDeleted == false).ToList();

            if (id == null)
            {
                return BadRequest("Id bos ola bilmez");
            }

            if (category.Id != id)
            {
                return BadRequest("Id bos ola bilmez");
            }

            Category existedCategory = _context.Categories.FirstOrDefault(c => c.IsDeleted == false && c.Id == id);

            if (existedCategory == null) return BadRequest();

            if (_context.Categories.Any(c => c.IsDeleted == false && c.Name.ToLower() == category.Name.ToLower().Trim() && c.Id != id))
            {
                ModelState.AddModelError("Name", $"This Name = {category.Name} Already Exisist");
                return View(category);
            }



            if (existedCategory == null)
            {
                return NotFound("Daxil edilen Id yalnisdir");
            }
            existedCategory.Name = category.Name.Trim();
            existedCategory.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedCategory.UpdatedBy = "System";


            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest("id null ola bilmez");
            }


               Category categories = _context.Categories
                .Include(c=> c.courses)
                .FirstOrDefault(c => !c.IsDeleted && c.Id == id);


            if (categories == null)
            {
                return NotFound("id yalnisdir");
            }

            return View(categories);
        }
    }
}
