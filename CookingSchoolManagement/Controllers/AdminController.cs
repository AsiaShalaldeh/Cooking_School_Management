using CookingSchoolManagement.Interfaces;
using CookingSchoolManagement.Models;
using CookingSchoolManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace CookingSchoolManagement.Controllers
{
    //[Route("")]
    [ApiController]
    class AdminController : Controller
    {
        IAdminService _adminService;
        ICourseService _courseService;
        public AdminController(IAdminService adminService,ICourseService courseService)
        {
            _adminService = adminService;
            _courseService = courseService;
        }
        [HttpGet]
        [Route("admin/courses")]
        public IActionResult GetAllCourses()
        {
            try
            {
                Console.WriteLine("Nothingggggggggg");
                IEnumerable<Course> courses = _courseService.GetCourses();
                if (courses == null) return NotFound("Courses Not Found!!");
                return Ok(courses);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
