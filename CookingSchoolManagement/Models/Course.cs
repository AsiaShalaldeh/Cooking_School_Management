using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CookingSchoolManagement.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Admin")]
        public int AdminID { get; set; }
        public Admin Admin { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
