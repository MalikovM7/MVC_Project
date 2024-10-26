using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Common;

namespace Persistence.Repositories
{
    public class ServiceRepository : AsyncRepository<ServiceModel>, IServiceRepository
    {
        public ServiceRepository(DbContext db)
            :base(db)
        {
            
        }
    }
}
