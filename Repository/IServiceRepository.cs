using Domain.Models;
using Repositories.Common;

namespace Repositories
{
    public interface IServiceRepository : IAsyncRepository<ServiceModel>
    {
    }
}
