using catedra1.src.Data;
using catedra1.src.Interfaces;
using catedra1.src.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AplicationDBcontext>(opt => opt.UseSqlite("Data Source=catedra1.db"));
builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AplicationDBcontext>();
    await context.Database.MigrateAsync();
    await Seeder.Seed(context);
}

app.MapControllers();



app.Run();

