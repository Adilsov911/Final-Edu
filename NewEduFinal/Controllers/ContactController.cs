using Microsoft.AspNetCore.Mvc;
using NewEduFinal.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Dictionary<string, string> settings = _context.Settings.ToDictionary(k=>k.Key, t=>t.Value);
            return View();
        }
    }
}
