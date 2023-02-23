using CookingSchoolManagement.Data;
using CookingSchoolManagement.Interfaces;
using CookingSchoolManagement.Models;
using CookingSchoolManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookingSchoolManagement.Services
{
    public class StudentService : IStudentService
    {
        private readonly SchoolContext _context;
        public StudentService(SchoolContext context)
        {
            _context = context;
        }

        public ResponseModel AddMealToFavorites(int student_id, int meal_id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Meal>> FilterMealsByArea(string area)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Meal>> FilterMealsByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Meal>> FilterMealsByMainIngredient(string main_ingredient)
        {
            throw new NotImplementedException();
        }

        public Task<Meal> GetMealByName(string meal_name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Meal>> GetMealsByFirstLetter(char first_letter)
        {
            throw new NotImplementedException();
        }

        public Task<Meal> GetRandomMeal()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            IEnumerable<Student> students = null;
            try
            {
                students = _context.Students.ToList();
                return students;
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public ResponseModel Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public ResponseModel Logout()
        {
            throw new NotImplementedException();
        }

        public ResponseModel Register(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
