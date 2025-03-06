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
            var courses = new List<Course>()
            {
                new Course { Id = 1, Title = "ASP.NET Core MVC" , Description = "Great course" },
                new Course { Id = 2, Title = "ASP.NET Core Web API" , Description = "Great course" },
                new Course { Id = 3, Title = "ASP.NET Core Razor Pages" , Description = "Great course" }
            };
            return View(courses);
        }
    }
}
