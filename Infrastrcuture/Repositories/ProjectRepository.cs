using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Common;

namespace Persistence.Repositories
{
    public class ProjectRepository : AsyncRepository<Project>, IProjectRepository
    {
        public ProjectRepository(DbContext db)
            :base(db) 
        {
            
        }
    }
}
