using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace week50_mini_project_mvc_movie.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
