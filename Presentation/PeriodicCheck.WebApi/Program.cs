using PeriodicCheck.Application.Features.CQRS.Handler.AuthorityHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.CareDetailHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.CareHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.CareMaterialHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.CareNameHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.CategoryHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.EquipmentHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.FaultDetailHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.FaultHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.FaultNameHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.MaterialHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.RoleAuthorityHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.RoleHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.StockHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.UserHandler;
using PeriodicCheck.Application.Features.CQRS.Handler.WarehouseHandler;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Persistence.Context;
using PeriodicCheck.Persistence.Repositories;

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


builder.Services.AddScoped<GetUserQueryHandler>();
builder.Services.AddScoped<GetUserByIdQueryHandler>();
builder.Services.AddScoped<CreateUserCommandHandler>();
builder.Services.AddScoped<RemoveUserCommandHandler>();
builder.Services.AddScoped<UpdateUserCommandHandler>();


builder.Services.AddScoped<GetRoleQueryHandler>();
builder.Services.AddScoped<GetRoleByIdQueryHandler>();
builder.Services.AddScoped<CreateRoleCommandHandler>();
builder.Services.AddScoped<RemoveRoleCommandHandler>();
builder.Services.AddScoped<UpdateRoleCommandHandler>();



builder.Services.AddScoped<GetCareDetailQueryHandler>();
builder.Services.AddScoped<GetCareDetailByIdQueryHandler>();
builder.Services.AddScoped<CreateCareDetailCommandHandler>();
builder.Services.AddScoped<RemoveCareDetailCommandHandler>();
builder.Services.AddScoped<UpdateCareDetailCommandHandler>();

builder.Services.AddScoped<GetFaultNameQueryHandler>();
builder.Services.AddScoped<GetFaultNameByIdQueryHandler>();
builder.Services.AddScoped<CreateFaultNameCommandHandler>();
builder.Services.AddScoped<RemoveFaultNameCommandHandler>();
builder.Services.AddScoped<UpdateFaultNameCommandHandler>();


builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();



builder.Services.AddScoped<GetEquipmentQueryHandler>();
builder.Services.AddScoped<GetEquipmentByIdQueryHandler>();
builder.Services.AddScoped<CreateEquipmentCommandHandler>();
builder.Services.AddScoped<RemoveEquipmentCommandHandler>();
builder.Services.AddScoped<UpdateEquipmentCommandHandler>();


builder.Services.AddScoped<GetFaultDetailQueryHandler>();
builder.Services.AddScoped<GetFaultDetailByIdQueryHandler>();
builder.Services.AddScoped<CreateFaultDetailCommandHandler>();
builder.Services.AddScoped<UpdateFaultDetailCommandHandler>();
builder.Services.AddScoped<RemoveFaultDetailCommandHandler>();

builder.Services.AddScoped<GetWarehouseQueryHandler>();
builder.Services.AddScoped<GetWarehouseByIdQueryHandler>();
builder.Services.AddScoped<CreateWarehouseCommandHandler>();
builder.Services.AddScoped<RemoveWarehouseCommandHandler>();
builder.Services.AddScoped<UpdateWarehouseCommandHandler>();

builder.Services.AddScoped<GetStockQueryHandler>();
builder.Services.AddScoped<GetStockByIdQueryHandler>();
builder.Services.AddScoped<CreateStockCommandHandler>();
builder.Services.AddScoped<RemoveStockCommandHandler>();
builder.Services.AddScoped<UpdateStockCommandHandler>();

builder.Services.AddScoped<GetMaterialQueryHandler>();
builder.Services.AddScoped<GetMaterialByIdQueryHandler>();
builder.Services.AddScoped<CreateMaterialCommandHandler>();
builder.Services.AddScoped<RemoveMaterialCommandHandler>();
builder.Services.AddScoped<UpdateMaterialCommandHandler>();



builder.Services.AddScoped<GetFaultQueryHandler>();
builder.Services.AddScoped<GetFaultByIdQueryHandler>();
builder.Services.AddScoped<CreateFaultCommandHandler>();
builder.Services.AddScoped<RemoveFaultCommandHandler>();
builder.Services.AddScoped<UpdateFaultCommandHandler>();


builder.Services.AddScoped<GetRoleAuthorityQueryHandler>();
builder.Services.AddScoped<GetRoleAuthorityByIdQueryHandler>();
builder.Services.AddScoped<CreateRoleAuthorityCommandHandler>();
builder.Services.AddScoped<RemoveRoleAuthorityCommandHandler>();
builder.Services.AddScoped<UpdateRoleAuthorityCommandHandler>();



builder.Services.AddScoped<GetCareMaterialByIdQueryHandler>();
builder.Services.AddScoped<GetCareMaterialQueryHandler>();
builder.Services.AddScoped<CreateCareMaterialCommandHandler>();
builder.Services.AddScoped<RemoveCareMaterialCommandHandler>();
builder.Services.AddScoped<UpdateCareMaterialCommandHandler>();



builder.Services.AddScoped<GetCareNameByIdQueryHandler>();
builder.Services.AddScoped<GetCareNameQueryHandler>();
builder.Services.AddScoped<CreateCareNameCommandHandler>();
builder.Services.AddScoped<RemoveCareNameCommandHandler>();
builder.Services.AddScoped<UpdateCareNameCommandHandler>();


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
