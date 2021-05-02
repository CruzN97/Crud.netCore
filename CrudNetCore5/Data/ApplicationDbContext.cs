using CrudNetCore5.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNetCore5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Libro> Libro { get; set; }
    }
}
