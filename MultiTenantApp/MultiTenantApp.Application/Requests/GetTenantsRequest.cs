using MediatR;
using MultiTenantApp.Application.Dto;
using MultiTenantApp.Contracts;

namespace MultiTenantApp.Application.Requests;

public class GetTenantsRequest : IRequest<Paged<TenantDto>>
{
    public int PageNumber { get; set; }

    public int PageSize { get; set; }
}

public class GetTenantsRequestHandler : IRequestHandler<GetTenantsRequest, Paged<TenantDto>>
{
    public Task<Paged<TenantDto>> Handle(
        GetTenantsRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}