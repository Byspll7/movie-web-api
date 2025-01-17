using Microsoft.EntityFrameworkCore;
using MovieWebApi.Models;

namespace MovieWebApi.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<MovieApp>? Movies { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
    }
}
