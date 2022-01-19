using MediatR;
using MultiTenantApp.Application.Dto;

namespace MultiTenantApp.Application.Requests;

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