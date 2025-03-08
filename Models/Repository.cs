using System.Dynamic;

namespace Basics.Models
{
    public class Repository
    {

        private static readonly List<Course> _courses = new List<Course>()
        {
            // Create a new course instance
            new Course { Id = 1, Title = "ASP.NET Core" , Description = "Great course", Image ="ASP.NET.webp" },
            new Course { Id = 2, Title = "Javascript" , Description = "Great course", Image ="Js.webp" },
            new Course { Id = 3, Title = "Python" , Description = "Great course", Image ="Python.webp" }
        };


        // Create a list of courses
        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}
