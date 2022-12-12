using Microsoft.EntityFrameworkCore;
using NewEduFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEduFinal.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseFeatures> CourseFeatures { get; set; }
        public DbSet<CourseTag> CourseTags { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventSpeaker> EventSpeakers { get; set; }
        public DbSet<Hobbie> Hobbies { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherHobbies> TeacherHobbies { get; set; }
        public DbSet<TeacherPosition> TeacherPositions { get; set; }
        public DbSet<TeacherSkills> TeacherSkills { get; set; }
        public DbSet<About> Abouts { get; set; }
    }
}
