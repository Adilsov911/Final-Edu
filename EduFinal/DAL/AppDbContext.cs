using EduFinal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduFinal.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ComingEvents> ComingEvents { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<MAbout> MAbouts { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Tags> Tags { get; set; }

    }
}
