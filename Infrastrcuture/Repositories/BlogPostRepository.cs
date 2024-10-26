using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Common;

namespace Persistence.Repositories
{
    public class BlogPostRepository : AsyncRepository<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository(DbContext db)
            :base(db)
        {

        }
    }
}
