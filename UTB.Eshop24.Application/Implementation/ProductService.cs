using UTB.Eshop24.Application.Abstraction;
using UTB.Eshop24.Domain.Entities;
using UTB.Eshop24.Infrastructure.Database;

namespace UTB.Eshop24.Application.Implementation
{
    public class ProductService : IProductService
    {
        EshopDbContext _context;
        public ProductService(EshopDbContext context)
        {
            _context = context;
        }

        public IList<Product> GetAll()
        {
            return _context.Products.ToList();
        }
    }
}
