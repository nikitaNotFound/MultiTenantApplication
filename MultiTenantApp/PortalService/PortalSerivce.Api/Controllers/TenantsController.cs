using Microsoft.AspNetCore.Mvc;
using MultiTenantApp.Infrastructure.Controllers;
using MultiTenantApp.Infrastructure.Models;
using PortalService.Application.Dto;
using PortalService.Application.Requests;

namespace PortalService.Api.Controllers;

[ApiController]
[Route("api/tenants")]
public class TenantsController : BaseApiController
{
    [HttpPost]
    public Task<TenantDto> CreateTenantAsync(CreateTenantRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpGet]
    public Task<Paged<TenantDto>> GetTenantsAsync(GetTenantsRequest request)
    {
        return Mediator.Send(request);
    }
}