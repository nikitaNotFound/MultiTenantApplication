using MediatR;
using PortalService.Application.Dto;

namespace PortalService.Application.Requests;

public class CreateTenantRequest : IRequest<TenantDto>
{
    public string Name { get; set; }
}

public class CreateTenantRequestHandler : IRequestHandler<CreateTenantRequest, TenantDto>
{
    public Task<TenantDto> Handle(
        CreateTenantRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}