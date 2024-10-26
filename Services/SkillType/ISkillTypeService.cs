using Services.Skills;

namespace Services.SkillType
{
    public interface ISkillTypeService
    {
        Task<IEnumerable<SkillTypeGetAll>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
