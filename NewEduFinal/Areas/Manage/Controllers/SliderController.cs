using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _env;
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Slider slider)
        {
            

            if (!ModelState.IsValid) return View();

            if (slider.SliderImgFile == null)
            {
                ModelState.AddModelError("ImageFile", "Choose image file!");
                return View();
            }
            if (!slider.SliderImgFile.IsImage())
            {
                ModelState.AddModelError("ImageFile", "Choose image file!");
                return View();
            }
            if (slider.Title == null )
            {
                ModelState.AddModelError("Title", "Do not leave blank!");
                return View(slider);

            }
            else if (slider.Title == null)
            {
                ModelState.AddModelError("Title", "Do not leave blank!");
                return View(slider);
            }

            slider.Title = slider.Title.Trim();
            slider.Image = slider.SliderImgFile.SaveImg(_env.WebRootPath, "Assets/img/slider");
            slider.IsDeleted = false;
            slider.CreatedAt = DateTime.UtcNow.AddHours(4);
            slider.CreatedBy = "System";

             _context.Sliders.Add(slider);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(hs => hs.Id == id);
            Slider existSlider = _context.Sliders.FirstOrDefault(s => s.Id == slider.Id);

            if (existSlider == null) return NotFound();
            if (slider == null) return Json(new { status = 404 });

            

            _context.Sliders.Remove(slider);
            _context.SaveChanges();

            return Json(new { status = 200 });

        }

    }
}
