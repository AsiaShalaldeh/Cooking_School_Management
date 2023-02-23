using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CookingSchoolManagement.Models
{
    public class Teacher
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccessToken { get; set; }

        [ForeignKey("Admin")]
        public int AdminID { get; set; }
        public Admin Admin { get; set; }
        public ICollection<Meal> Meals { get; set; }
        public ICollection<Homework> Homeworks { get; set; }
        public ICollection<Class> Classes { get; set; }
        public ICollection<Favorites> Favorites { get; set; }

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
