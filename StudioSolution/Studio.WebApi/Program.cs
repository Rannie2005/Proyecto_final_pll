using Microsoft.EntityFrameworkCore;
using Studio.Infrastructure.Context;
using Studio.Infrastructure.Repositories;
using Studio.Domain.Interfaces;


var builder = WebApplication.CreateBuilder(args);

// Connection string (ajusta Server si usas nombre de instancia)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                       ?? "Server=localhost;Database=StudioDB;Trusted_Connection=True;TrustServerCertificate=True;";

// Registrar DbContext
builder.Services.AddDbContext<StudioContext>(options =>
    options.UseSqlServer(connectionString));

// Registrar repositorios
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IEngineerRepository, EngineerRepository>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<ISessionRepository, SessionRepository>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
