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

        public void Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            Product product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}
