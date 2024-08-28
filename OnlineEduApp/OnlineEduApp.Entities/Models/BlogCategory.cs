namespace OnlineEduApp.Entities.Models
{
    public class BlogCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
