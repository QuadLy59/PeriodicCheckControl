using PeriodicCheck.Application.Features.CQRS.Handlers.CareHandlers;
using PeriodicCheck.Application.Features.CQRS.Handlers.CategoryHandlers;
using PeriodicCheck.Application.Features.CQRS.Handlers.EquipmentHandlers;
using PeriodicCheck.Application.Features.CQRS.Handlers.FaultHandlers;
using PeriodicCheck.Application.Features.CQRS.Handlers.NoticeHandlers;
using PeriodicCheck.Application.Features.CQRS.Handlers.PeriodicActivityStatusHandlers;
using PeriodicCheck.Application.Features.CQRS.Handlers.StockHandlers;
using PeriodicCheck.Application.Features.CQRS.Handlers.WarehouseHandlers;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Persistence.Context;
using PeriodicCheck.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<PeriodicCheckContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<GetCareQueryHandler>();
builder.Services.AddScoped<GetCareByIdQueryHandler>();
builder.Services.AddScoped<CreateCareCommandHandler>();
builder.Services.AddScoped<RemoveCareCommandHandler>();
builder.Services.AddScoped<UpdateCareCommandHandler>();

builder.Services.AddScoped<GetEquipmentQueryHandler>();
builder.Services.AddScoped<GetEquipmentByIdQueryHandler>();
builder.Services.AddScoped<CreateEquipmentCommandHandler>();
builder.Services.AddScoped<RemoveEquipmentCommandHandler>();
builder.Services.AddScoped<UpdateEquipmentCommandHandler>();

builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();

builder.Services.AddScoped<GetFaultQueryHandler>();
builder.Services.AddScoped<GetFaultByIdQueryHandler>();
builder.Services.AddScoped<CreateFaultCommandHandler>();
builder.Services.AddScoped<UpdateFaultCommandHandler>();
builder.Services.AddScoped<RemoveFaultCommandHandler>();

builder.Services.AddScoped<GetNoticeQueryHandler>();
builder.Services.AddScoped<GetNoticeByIdQueryHandler>();
builder.Services.AddScoped<CreateNoticeCommandHandler>();
builder.Services.AddScoped<UpdateNoticeCommandHandler>();
builder.Services.AddScoped<RemoveNoticeCommandHandler>();

builder.Services.AddScoped<GetStockQueryHandler>();
builder.Services.AddScoped<GetStockByIdQueryHandler>();
builder.Services.AddScoped<CreateStockCommandHandler>();
builder.Services.AddScoped<UpdateStockCommandHandler>();
builder.Services.AddScoped<RemoveStockCommandHandler>();


builder.Services.AddScoped<GetWarehouseQueryHandler>();
builder.Services.AddScoped<GetWarehouseByIdQueryHandler>();
builder.Services.AddScoped<CreateWarehouseCommandHandler>();
builder.Services.AddScoped<UpdateWarehouseCommandHandler>();
builder.Services.AddScoped<RemoveWarehouseCommandHandler>();

builder.Services.AddScoped<GetPeriodicActivityStatusQueryHandler>();
builder.Services.AddScoped<GetPeriodicActivityStatusByIdQueryHandler>();
builder.Services.AddScoped<CreatePeriodicActivityStatusCommandHandler>();
builder.Services.AddScoped<UpdatePeriodicActivityStatusCommandHandler>();
builder.Services.AddScoped<RemovePeriodicActivityStatusCommandHandler>();

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
