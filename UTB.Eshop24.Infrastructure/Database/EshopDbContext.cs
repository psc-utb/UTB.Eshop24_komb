using Microsoft.EntityFrameworkCore;
using UTB.Eshop24.Domain.Entities;
using UTB.Eshop24.Infrastructure.Database.Seedings;

namespace UTB.Eshop24.Infrastructure.Database
{
    public class EshopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public EshopDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ProductInit productInit = new ProductInit();
            modelBuilder.Entity<Product>().HasData(productInit.GetProductsFood2());
        }

    }
}
