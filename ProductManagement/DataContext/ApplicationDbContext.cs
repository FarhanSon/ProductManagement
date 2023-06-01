using Microsoft.EntityFrameworkCore;
using ProductManagement.Models;

namespace ProductManagement.DataContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        { 
  
        }

          public DbSet<CategoryInfo> Categories { get; set; }
        public DbSet<ProductInfo> Products { get; set; }
    }
}
