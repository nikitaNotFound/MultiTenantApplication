using MultiTenantApp.Infrastructure.Persistence;
using PortalService.Infustructure.Repositories.Contracts;

namespace PortalService.Infustructure.Repositories;

public class TenantRepository : BaseRepository<TenantRepository>, ITenantRepository
{
}