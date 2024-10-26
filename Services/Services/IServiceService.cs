
using Services.Services;

namespace Application.Services.Interfaces;

public interface IServiceService
{

    Task<IEnumerable<ServiceGetAll>> GetAllAsync(CancellationToken cancellationToken = default);

}
