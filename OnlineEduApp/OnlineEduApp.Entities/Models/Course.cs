namespace OnlineEduApp.Entities.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public int CategoryId { get; set; }
        public CourseCategory Category { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }
    }
}
