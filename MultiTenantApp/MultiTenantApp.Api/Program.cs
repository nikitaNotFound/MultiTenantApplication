using MediatR;
using MultiTenantApp.Infrastructure.DependencyInjection;
using MultiTenantApp.Infrastructure.Multitenancy;
using MultiTenantApp.Repository.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(typeof(Program));

builder.Services.AddInfrastructure();
builder.Services.AddRepositories();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<CurrentTenantInitializerMiddleware>();

app.Run();