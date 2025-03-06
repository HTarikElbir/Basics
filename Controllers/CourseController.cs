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
            course.Description = "Great course";
            course.Image = "ASP.NET.webp";

            return View(course);
        }

        public IActionResult List()
        {
            var courses = new List<Course>()
            {
                new Course { Id = 1, Title = "ASP.NET Core" , Description = "Great course", Image ="ASP.NET.webp" },
                new Course { Id = 2, Title = "Javascript" , Description = "Great course", Image ="Js.webp" },
                new Course { Id = 3, Title = "Python" , Description = "Great course", Image ="Python.webp" }
            };
            return View(courses);
        }
    }
}
