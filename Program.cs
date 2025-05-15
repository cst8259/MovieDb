using Microsoft.EntityFrameworkCore;
using MovieDb.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options => 
  options.UseSqlite("Data Source = MovieDb.sqlite"));
var app = builder.Build();

app.MapControllers();

app.Run();
