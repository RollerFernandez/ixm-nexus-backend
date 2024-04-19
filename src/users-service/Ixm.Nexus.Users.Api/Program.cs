using Autofac.Extensions.DependencyInjection;
using Autofac;
using Ixm.Nexus.Users.Infrastructure.Cores;
using Ixm.Nexus.Users.Application.Interfaces;
using Ixm.Nexus.Users.Application.Implementations;
using Ixm.Nexus.Users.Infrastructure.Repository.Implementations.Data;
using Microsoft.EntityFrameworkCore;
using Ixm.Nexus.Users.Application.Cores;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpContextAccessor();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(options => {
        var inf = options.RegisterModule(new InfrastructureAutoFacModule());
        var app = options.RegisterModule(new ApplicationAutoFacModule());
        //options.RegisterModule(new ApplicationAutoFacModule());
        //options.RegisterModule(new ExceptionMiddleware());
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
