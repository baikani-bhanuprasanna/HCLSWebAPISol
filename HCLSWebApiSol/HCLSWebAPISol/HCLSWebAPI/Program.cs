using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;
using HCLSWebAPI.HCLSContext;
using System.Data;
using Microsoft.AspNetCore.DataProtection.Repositories;
using HCLSWebAPI.DataAcess.IRepository;
using HCLSWebAPI.DataAcess.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<HCLSContextPro>(options =>
    options.UseSqlServer("server=BHANUPRASANNA\\SQLEXPRESS;Uid=sa;password=12345;database=DataS"));



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IAdminDetailRepository, AdminDetailRepository>();
builder.Services.AddTransient<IAdminRepository, AdminRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
