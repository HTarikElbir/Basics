namespace Basics.Models
{
    // Represents a course with an ID, title, image, and description
    public class Course
    {
        public int Id { get; set; }
       
        public string? Title { get; set; }

        public string? Image { get; set; }  

        public string? Description { get; set; }

    }
}
