using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CookingSchoolManagement.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccessToken { get; set; }
        public int Level { get; set; }
        public ICollection<Meal> Meals { get; set; }
        public ICollection<Favorites> Favorites { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }

        public void Login()
        {
            AccessToken = Guid.NewGuid().ToString();
        }
        public void Logout()
        {
            AccessToken = null;
        }

    }
}
