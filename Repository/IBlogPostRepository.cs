using Domain.Models;
using Repositories.Common;

namespace Repositories
{
    public interface IBlogPostRepository : IAsyncRepository<BlogPost>
    {
    }
}
