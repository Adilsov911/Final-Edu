using Microsoft.EntityFrameworkCore;
using NewEduFinal.DAL;
using NewEduFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public Setting GetSettingData()
        {
            return _context.Settings.FirstOrDefault();
            
        }
    }
}
