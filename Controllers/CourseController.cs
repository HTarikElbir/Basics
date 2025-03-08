using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            // Create a new course instance
            Course course = new Course();

            // Set course properties
            course.Id = 1;
            course.Title = "ASP.NET Core MVC";
            course.Description = "Great course";
            course.Image = "ASP.NET.webp";

            // Return the course to the view
            return View(course);
        }

        public IActionResult List()
        {
            // Create a list of courses
            var courses = new List<Course>()
            {
                new Course { Id = 1, Title = "ASP.NET Core" , Description = "Great course", Image ="ASP.NET.webp" },
                new Course { Id = 2, Title = "Javascript" , Description = "Great course", Image ="Js.webp" },
                new Course { Id = 3, Title = "Python" , Description = "Great course", Image ="Python.webp" }
            };
            // Return the list of courses to the view
            return View(courses);
        }
        public IActionResult Details()
        {
            // Create a new course instance
            Course course = new Course();

            // Set course properties
            course.Id = 1;
            course.Title = "ASP.NET Core MVC";
            course.Description = "Great course";
            course.Image = "ASP.NET.webp";

            // Return the course to the view
            return View(course);
        }
    }
}
