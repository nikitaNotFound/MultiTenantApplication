using Microsoft.AspNetCore.Mvc;
using MultiTenantApp.Application.Dto;
using MultiTenantApp.Application.Requests;

namespace MultiTenantApp.Api.Controllers.Tenants;

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