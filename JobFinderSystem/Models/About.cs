namespace SchoolSystem.Models
{
    public class About
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }

        public string ImagePath { get; set; }
        public IFormFile Photo { get; set; }
    }
}
