using Clean.Architecture.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Architecture.MVC.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
          var model=  _courseService.GetCourses();
            return View(model);
        }

        public IActionResult GetCourse(int courseId)
        {
            var model = _courseService.GetCourse(courseId);
            return View(model);
        }
    }
}
