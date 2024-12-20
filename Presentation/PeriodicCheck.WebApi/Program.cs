using PeriodicCheck.Application.Features.CQRS.Handler.AuthorityHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.CareHandler;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Persistence.Context;
using PeriodicCheck.Persistence.Repositories;
using SurveySystem.Application.Features.CQRS.Handlers.RoleHandlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<PeriodicCheckContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<GetAuthorityQueryHandler>();
builder.Services.AddScoped<GetAuthorityByIdQueryHandler>();
builder.Services.AddScoped<CreateAuthorityCommandHandler>();
builder.Services.AddScoped<UpdateAuthorityCommandHandler>();
builder.Services.AddScoped<RemoveAuthorityCommandHandler>();

builder.Services.AddScoped<GetCareQueryHandler>();
builder.Services.AddScoped<GetCareByIdQueryHandler>();
builder.Services.AddScoped<CreateCareCommandHandler>();
builder.Services.AddScoped<RemoveCareCommandHandler>();
builder.Services.AddScoped<UpdateCareCommandHandler>();

builder.Services.AddScoped<GetRoleQueryHandler>();
builder.Services.AddScoped<GetRoleByIdQueryHandler>();
builder.Services.AddScoped<CreateRoleCommandHandler>();
builder.Services.AddScoped<RemoveRoleCommandHandler>();
builder.Services.AddScoped<UpdateRoleCommandHandler>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
