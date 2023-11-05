using LetsShopping.Domain.Models.Products;
using LetsShopping.Service.Dtos.ProductsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.DataAccess.Repositories.ProductRepositories
{
    public interface IProductRepository : IBaseRepository<Product, ProductDto>
    {
    }
}
