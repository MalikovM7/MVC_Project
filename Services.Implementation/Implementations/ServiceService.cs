using Application.Services.Interfaces;

using Microsoft.EntityFrameworkCore;
using Repositories;
using Services.Services;

namespace Application.Services.Implementations;

public class ServiceService : IServiceService
{
    private readonly IServiceRepository serviceRepository;

    public ServiceService(IServiceRepository serviceRepository)
    {
        this.serviceRepository = serviceRepository;
    }

    public async Task<IEnumerable<ServiceGetAll>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await serviceRepository.GetAll()
             .Select(m => new ServiceGetAll
            {
                Id = m.Id,
                Title = m.Title,
                Description = m.Description,
                CssClass = m.CssClass,

            })
            .ToListAsync();
    }

}

