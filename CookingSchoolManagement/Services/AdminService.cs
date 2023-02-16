using CookingSchoolManagement.Data;
using CookingSchoolManagement.Interfaces;
using CookingSchoolManagement.Models;
using Microsoft.EntityFrameworkCore;
using CookingSchoolManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingSchoolManagement.Services
{
    class AdminService : IAdminService
    {
        private readonly SchoolContext _context;
        public AdminService(SchoolContext context)
        {
            _context = context;
        }
        public ResponseModel CreateCourse(Course course)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                _context.Add<Course>(course);
                model.Messsage = "Course Inserted Successfully";

                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public ResponseModel CreateTeacher(Teacher teacher)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                _context.Add<Teacher>(teacher);
                model.Messsage = "Teacher Inserted Successfully";

                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public async Task<IEnumerable<Class>> GetClasses()
        {
            IList<Class> classesList;
            try
            {
                classesList =  _context.Classes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return classesList;
        }

        public async Task<IEnumerable<Favorites>> GetFavorites()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            IList<Student> studentsList;
            try
            {
                studentsList = _context.Students.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return studentsList;
        }

        public async Task<IEnumerable<Teacher>> GetTeachers()
        {
            IList<Teacher> teachersList;
            try
            {
                teachersList = _context.Teachers.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return teachersList;
        }

        public ResponseModel Login(string email, string password)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Admin admin = _context.Admins.Where(a => a.Email == email && a.Password == password).Single();
                if (admin != null)
                {
                    admin.Login();
                    model.Messsage = "Login Done Successfully";
                    model.IsSuccess = true;
                    _context.SaveChanges();
                }
                else
                {
                    model.Messsage = "Login Failed";
                    model.IsSuccess = false;
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public ResponseModel Logout()
        {
            ResponseModel model = new ResponseModel();
            //try
            //{
            //    admin.Login();
            //    model.Messsage = "Logout Done Successfully";
            //    model.IsSuccess = true;
            //    _context.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    model.IsSuccess = false;
            //    model.Messsage = "Error : " + ex.Message;
            //}
            return model;
        }
    }
}
