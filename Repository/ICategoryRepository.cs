using Domain.Models;
using Repositories.Common;

namespace Repositories
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
    }
}
