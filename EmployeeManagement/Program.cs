using EmployeeManagement.DBContextLayer;
using Microsoft.EntityFrameworkCore;
using BusinessLayer.Interfaces;
using BusinessLayer.ServiceLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDBContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IEmployee, EmployeeServices>();
builder.Services.AddScoped<IJobDetails, JobDetailsServices>();
builder.Services.AddScoped<ILeaveTable, LeaveTableServices>();
builder.Services.AddScoped<ILeaveReq, LeaveReqServices>();

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
