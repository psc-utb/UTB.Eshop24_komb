using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.Eshop24.Domain.Entities;

namespace UTB.Eshop24.Application.Abstraction
{
    public interface IProductService
    {
        IList<Product> GetAll();
    }
}
