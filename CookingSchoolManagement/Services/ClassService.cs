using CookingSchoolManagement.Data;
using CookingSchoolManagement.Interfaces;
using CookingSchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookingSchoolManagement.Services
{
    public class ClassService : IClassService
    {
        private readonly SchoolContext _context;
        public ClassService(SchoolContext context)
        {
            _context = context;
        }
        public IEnumerable<Class> GetClasses()
        {

            IEnumerable<Class> classes = null;
            try
            {
                classes = _context.Classes.ToList();
                return classes;
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
    }
}
