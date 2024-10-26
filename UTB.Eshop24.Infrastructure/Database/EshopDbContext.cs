using Microsoft.EntityFrameworkCore;
using UTB.Eshop24.Domain.Entities;

namespace UTB.Eshop24.Infrastructure.Database
{
    public class EshopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public EshopDbContext(DbContextOptions options) : base(options) { }

    }
}
