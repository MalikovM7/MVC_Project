using Microsoft.EntityFrameworkCore;
using Repositories;
using Services.SkillType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation.Implementations
{
    public class SkillTypeService(ISkillTypeRepository skillTypeRepository) : ISkillTypeService
    {
        public async Task<IEnumerable<SkillTypeGetAll>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await skillTypeRepository.GetAll()
                 .Select(x => new SkillTypeGetAll
 
                 {
                     Id = x.Id,
                     Name = x.Name,
                 }).ToListAsync();
        }
    }
}
