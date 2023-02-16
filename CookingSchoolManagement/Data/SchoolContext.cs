using CookingSchoolManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookingSchoolManagement.Data
{
    class SchoolContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public SchoolContext(DbContextOptions<SchoolContext> options)
        : base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Favorites> Favorites { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=DESKTOP-TD29OVV;Initial Catalog=CookingSchoolDb;Integrated Security=True");
                optionsBuilder.UseSqlServer("MyConn");

            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Favorites>()
                .HasKey(f => new { f.MealID, f.UserID });
            modelBuilder.Entity<StudentCourse>().HasKey(sc =>
            new { sc.StudentID, sc.CourseID });
        }
    }
}
