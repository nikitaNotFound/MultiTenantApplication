using Microsoft.AspNetCore.Mvc;
using MultiTenantApp.Infrastructure.Controllers;
using Portal.Application.Dto;
using Portal.Application.Requests;

namespace Portal.Api.Controllers;

[ApiController]
[Route("api/tenants")]
public class TenantsController : BaseApiController
{
    [HttpPost]
    public Task<TenantDto> CreateTenantAsync(CreateTenantRequest request)
    {
        return Mediator.Send(request);
    }
}