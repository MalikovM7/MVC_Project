using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Common;

namespace Persistence.Repositories
{
    public class PersonSkillRepository : AsyncRepository<PersonSkill>, IPersonSkillRepository
    {
        public PersonSkillRepository(DbContext db)
            :base(db)
        {
            
        }
    }
}
