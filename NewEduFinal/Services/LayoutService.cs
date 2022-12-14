using Microsoft.EntityFrameworkCore;
using NewEduFinal.DAL;
using NewEduFinal.Interfaces;
using NewEduFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.Services
{
    public class LayoutService : ILayoutServices
    {
        private readonly AppDbContext _context;
        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public Dictionary<string, string> GetSettingData()
        {
             
            return _context.Settings.ToDictionary(k => k.Key, t => t.Value);
            
        }
    }
}
