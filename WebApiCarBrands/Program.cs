using Microsoft.EntityFrameworkCore;
using WebApiCarBrands.Application.Interfaces;
using WebApiCarBrands.Application.Services;
using WebApiCarBrands.Infrastructure.Data;
using WebApiCarBrands.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();

// Add services to the container.
builder.Services.AddDbContext<CarBrandDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICarBrandRepository, CarBrandRepository>();
builder.Services.AddScoped<ICarBrandService, CarBrandService>();
builder.Services.AddScoped<CarBrandService>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
