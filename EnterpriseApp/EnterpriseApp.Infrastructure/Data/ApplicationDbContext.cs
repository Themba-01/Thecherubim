using EnterpriseApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseApp.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
