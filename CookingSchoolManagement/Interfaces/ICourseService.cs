using CookingSchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CookingSchoolManagement.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<Course> GetCourses();
    }
}
