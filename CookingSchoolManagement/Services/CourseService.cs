using CookingSchoolManagement.Data;
using CookingSchoolManagement.Interfaces;
using CookingSchoolManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingSchoolManagement.Services
{
    class CourseService : ICourseService
    {
        private readonly SchoolContext _context;
        public CourseService(SchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            Console.WriteLine("From Courses");
            try
            {
                return _context.Courses.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
    }
}
