using Domain.Models;
using Repositories.Common;

namespace Repositories
{
    public interface IProjectRepository : IAsyncRepository<Project>
    {
    }
}
