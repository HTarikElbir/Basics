using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class CourseController : Controller
    {
       
        public IActionResult List()
        {   
            // Return the list of courses to the view
            return View(Repository.Courses);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return Redirect("/Course/list");
            }
            var course = Repository.GetById(id);
            // Return the course to the view
            return View(course);
        }
    }
}
