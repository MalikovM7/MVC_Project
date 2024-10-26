using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Common;
using Repositories;

namespace Persistence.Repositories
{
    internal class ContactPostRepository : AsyncRepository<ContactPost>, IContactPostRepository
    {
        public ContactPostRepository(DbContext db)
            :base(db)
        {
            
        }
    }
}
