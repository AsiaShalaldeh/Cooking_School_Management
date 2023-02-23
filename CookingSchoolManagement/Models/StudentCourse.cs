using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CookingSchoolManagement.Models
{
    public class StudentCourse
    {
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; }

        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public Course Course { get; set; }

    }
}
