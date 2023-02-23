using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CookingSchoolManagement.Models
{
    public class Meal
    {
        [Key]
        public int ID { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public string Category { get; set; }
        public string Area { get; set; }
        public string MainIngredient { get; set; }

    }
}
