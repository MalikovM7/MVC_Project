namespace Services.Skills
{
    public interface ISkillService
    {
        Task<IEnumerable<SkillGetAll>> GetAllAsync(CancellationToken cancellationToken=default);
    }
}
