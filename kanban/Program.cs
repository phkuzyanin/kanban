using Microsoft.EntityFrameworkCore;
using Kanban.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.Run();
