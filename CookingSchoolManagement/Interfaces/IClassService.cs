using CookingSchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookingSchoolManagement.Interfaces
{
    public interface IClassService
    {
        IEnumerable<Class> GetClasses();

    }
}
