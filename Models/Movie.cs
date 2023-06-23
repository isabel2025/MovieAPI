using System;
namespace MovieAPI.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Director { get; set; }
    public string? Genre { get; set; }
    public decimal Ratings { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

}

