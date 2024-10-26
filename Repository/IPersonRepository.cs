using Domain.Models;
using Repositories.Common;

namespace Repositories
{
    public interface IPersonRepository : IAsyncRepository<Person>
    {
    }
}
