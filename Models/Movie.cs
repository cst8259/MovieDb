using System;

namespace MovieDb.Models;

public class Movie
{
  public int Id { get; set; }
  public string Title { get; set; } = string.Empty;
  public int ReleaseYear { get; set; }
}
