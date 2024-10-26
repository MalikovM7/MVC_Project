namespace Services.BlogPosts
{
    public class BlogPostGetAll
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
        public string? ImagePath { get; set; }
        public int CategoryId { get; set; }
        public DateTime? PublishDate { get; set; }
        public int? PublisherId { get; set; }
    }
}
