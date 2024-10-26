using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.Eshop24.Domain.Entities;

namespace UTB.Eshop24.Infrastructure.Database.Seedings
{
    internal class ProductInit
    {
        public IList<Product> GetProductsFood2()
        {
            IList<Product> products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "Chleba",
                Description = "Nejlepší chleba na světě",
                Price = 50,
                ImageSrc = ""
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "Rohlík",
                Description = "Nejlepší rohlík v galaxii",
                Price = 2,
                ImageSrc = ""
            });

            return products;
        }
    }
}
