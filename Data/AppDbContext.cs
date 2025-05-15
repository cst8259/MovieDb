using System;
using Microsoft.EntityFrameworkCore;
using MovieDb.Models;

namespace MovieDb.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
   
  public DbSet<Movie> Movies { get; set; }
  public DbSet<Genre> Genres { get; set; }
  public DbSet<GenreMovie> GenreMovies { get; set; }
}
