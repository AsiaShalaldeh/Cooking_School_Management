using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CookingSchoolManagement.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccessToken { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Course> Courses { get; set; }

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
