using CookingSchoolManagement.Models;
using CookingSchoolManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CookingSchoolManagement.Interfaces
{
    interface IAdminService
    {
        ResponseModel Login(string email, string password);
        ResponseModel Logout();
        ResponseModel CreateTeacher(Teacher teacher);
        ResponseModel CreateCourse(Course course);
        Task<IEnumerable<Teacher>> GetTeachers();
        Task<IEnumerable<Student>> GetStudents();
        Task<IEnumerable<Class>> GetClasses();
        Task<IEnumerable<Favorites>> GetFavorites();
    }
}
