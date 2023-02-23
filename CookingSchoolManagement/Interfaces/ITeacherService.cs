using CookingSchoolManagement.Models;
using CookingSchoolManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookingSchoolManagement.Interfaces
{
    public interface ITeacherService
    {
        ResponseModel Login(string email, string password);
        ResponseModel Logout();
        ResponseModel CreateClass(Class _class);
        ResponseModel CreateHomework(Homework homework);
        ResponseModel AddStudentToCourse(int studentId, int courseId);
        IEnumerable<Teacher> GetTeachers();
    }
}
