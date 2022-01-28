using Microsoft.AspNetCore.Mvc;
using MultiTenantApp.Contracts;
using MultiTenantApp.Infrastructure.Controllers;
using Portal.Application.Dto;
using Portal.Application.Requests;

namespace Portal.Api.Controllers;

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