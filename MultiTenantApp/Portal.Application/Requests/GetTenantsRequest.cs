using MediatR;
using MultiTenantApp.Contracts;
using Portal.Application.Dto;

namespace Portal.Application.Requests;

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