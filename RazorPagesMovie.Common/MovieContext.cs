using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Common.Models;

namespace RazorPagesMovie.Common
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
