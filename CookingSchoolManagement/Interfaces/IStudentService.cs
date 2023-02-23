using CookingSchoolManagement.Models;
using CookingSchoolManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CookingSchoolManagement.Interfaces
{
    public interface IStudentService
    {
        ResponseModel Login(string email, string password);
        ResponseModel Logout();
        ResponseModel Register(string email, string password);
        Task<Meal> GetMealByName(string meal_name);
        Task<IEnumerable<Meal>> GetMealsByFirstLetter(char first_letter);
        Task<Meal> GetRandomMeal();
        IEnumerable<Student> GetStudents();
        ResponseModel AddMealToFavorites(int student_id, int meal_id);
        Task<IEnumerable<Meal>> FilterMealsByCategory(string category);
        Task<IEnumerable<Meal>> FilterMealsByArea(string area);
        Task<IEnumerable<Meal>> FilterMealsByMainIngredient(string main_ingredient);

    }
}
