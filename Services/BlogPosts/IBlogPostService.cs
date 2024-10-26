namespace Services.BlogPosts
{
    public interface IBlogPostService
    {
        Task<IEnumerable<BlogPostGetAll>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
