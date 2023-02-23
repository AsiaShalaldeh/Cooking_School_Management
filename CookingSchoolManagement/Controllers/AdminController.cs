using CookingSchoolManagement.Interfaces;
using CookingSchoolManagement.Models;
using CookingSchoolManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace CookingSchoolManagement.Controllers
{
    [Route("admin")]
    [ApiController]
    public class AdminController : Controller
    {
        IAdminService _adminService;
        ICourseService _courseService;
        IStudentService _studentService;
        IClassService _classService;
        IFavoritesService _favoriteService;
        ITeacherService _teacherService;

        public AdminController(IAdminService adminService,ICourseService courseService
            , IStudentService studentService, IClassService classService, IFavoritesService favoriteService,
            ITeacherService teacherService)
        {
            _adminService = adminService;
            _courseService = courseService;
            _studentService = studentService;
            _classService = classService;
            _favoriteService = favoriteService;
            _teacherService = teacherService;
        }
        [HttpGet]
        [Route("courses")]
        public IActionResult GetAllCourses()
        {
            try
            {
                IEnumerable<Course> courses = _courseService.GetCourses();
                if (courses == null) return NotFound("Courses Not Found!!");
                return Ok(courses);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("students")]
        public IActionResult GetAllStudents()
        {
            IEnumerable<Student> students = null;
            try
            {
                students = _studentService.GetStudents(); 
                if (students == null) return NotFound("Students Not Found!!");
                return Ok(students);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("classes")]
        public IActionResult GetAllClasses()
        {
            IEnumerable<Class> classes = null;
            try
            {
                classes = _classService.GetClasses();
                if (classes == null) return NotFound("Classes Not Found!!");
                return Ok(classes);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("favorites")]
        public IActionResult GetAllFavorites()
        {
            IEnumerable<Favorites> favorites = null;
            try
            {
                favorites = _favoriteService.GetFavorites();
                if (favorites == null) return NotFound("Favorites Not Found!!");
                return Ok(favorites);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("teachers")]
        public IActionResult GetAllTeachers()
        {
            IEnumerable<Teacher> teachers = null;
            try
            {
                teachers = _teacherService.GetTeachers();
                if (teachers == null) return NotFound("Teachers Not Found!!");
                return Ok(teachers);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
