using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Common;

namespace Persistence.Repositories
{
    public class PersonRepository : AsyncRepository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext db)
            :base(db)
        {
            
        }
    }
}
