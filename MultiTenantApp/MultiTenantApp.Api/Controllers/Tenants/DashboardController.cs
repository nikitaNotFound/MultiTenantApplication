using Microsoft.AspNetCore.Mvc;
using MultiTenantApp.Application.Dto;
using MultiTenantApp.Application.Requests;
using MultiTenantApp.Contracts;

namespace MultiTenantApp.Api.Controllers.Tenants;

[ApiController]
[Route("api/dashboard")]
public class DashboardController : BaseApiController
{
    [HttpGet("tenants")]
    public Task<Paged<TenantDto>> GetTenantsAsync(GetTenantsRequest request)
    {
        return Mediator.Send(request);
    }
}