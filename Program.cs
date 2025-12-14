using Microsoft.EntityFrameworkCore;
using EmployeeManagement.API.Data;
using EmployeeManagement.API.Repositories.Interfaces;
using EmployeeManagement.API.Repositories;

var builder = WebApplication.CreateBuilder(args);
// Register EF Core + SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//register repository pattern
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

app.Run();

