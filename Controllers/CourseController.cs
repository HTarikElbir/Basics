using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            Course course = new Course();
            
            course.Id = 1;
            course.Title = "ASP.NET Core MVC";

            return View(course);
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
