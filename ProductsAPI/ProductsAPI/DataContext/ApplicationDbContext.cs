using ProductsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductsAPI.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
