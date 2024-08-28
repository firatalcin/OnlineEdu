namespace OnlineEduApp.Entities.Models
{
    public class CourseCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool IsShown { get; set; }
        public List<Course> Courses { get; set; }
    }
}
