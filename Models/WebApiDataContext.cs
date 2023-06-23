using System;
using Microsoft.EntityFrameworkCore;

namespace MovieAPI.Models
{
	public class WebApiDataContext : DbContext 
	{
        public WebApiDataContext(DbContextOptions<WebApiDataContext> options)
            : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}

