using CookingSchoolManagement.Data;
using CookingSchoolManagement.Interfaces;
using CookingSchoolManagement.Models;
using CookingSchoolManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookingSchoolManagement.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly SchoolContext _context;
        public TeacherService(SchoolContext context)
        {
            _context = context;
        }
        public ResponseModel AddStudentToCourse(int studentId, int courseId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Student student = _context.Students.Where(s => s.ID == studentId).Single();
                Course course = _context.Courses.Where(c => c.ID == courseId).Single();
                if (student == null && course == null)
                {
                    model.Messsage = "Student And Course Are Not Found";
                    model.IsSuccess = false;
                    return model;
                }
                if (student == null)
                {
                    model.Messsage = "Student Not Found";
                    model.IsSuccess = false;
                    return model;
                }
                if (course == null)
                {
                    model.Messsage = "Course Not Found";
                    model.IsSuccess = false;
                    return model;
                }
                StudentCourse studentCourse = new StudentCourse()
                {
                    StudentID = studentId,
                    CourseID = courseId
                };
                _context.StudentCourses.Add(studentCourse);
                course.StudentCourses.Add(studentCourse);
                student.StudentCourses.Add(studentCourse);
                _context.Students.Update(student);
                _context.Courses.Update(course);

                model.Messsage = "Class Inserted Successfully";

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

        public ResponseModel CreateClass(Class _class)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                _context.Add<Class>(_class);
                model.Messsage = "Class Inserted Successfully";

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

        public ResponseModel CreateHomework(Homework homework)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                _context.Add<Homework>(homework);
                model.Messsage = "Homework Inserted Successfully";

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

        public IEnumerable<Teacher> GetTeachers()
        {
            try
            {
                return _context.Teachers.ToList();
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
    }
}
