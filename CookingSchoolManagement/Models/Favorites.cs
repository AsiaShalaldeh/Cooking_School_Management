using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CookingSchoolManagement.Models
{
    public class Favorites
    {
        [Required]
        public int MealID { get; set; }
        [Required]
        public int UserID { get; set; }
        public string UserEmail { get; set; }

    }
}
