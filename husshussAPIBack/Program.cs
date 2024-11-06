using husshussAPIBack.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(8, 0, 21))));

 
// Ajouter le service DbContext avec MySQL
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                  .AllowAnyHeader()
                  .AllowAnyMethod()
                  .AllowCredentials(); // Ajoute ceci si tu utilises des identifiants d'authentification
        });
});

 

// Ajouter les autres services
builder.Services.AddControllers();

var app = builder.Build();

app.UseCors("AllowAngularApp");
app.MapControllers();

app.Run();
