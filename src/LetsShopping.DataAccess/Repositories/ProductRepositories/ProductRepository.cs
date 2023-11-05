using LetsShopping.Domain.Models.Products;
using LetsShopping.Service.Dtos.ProductsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.DataAccess.Repositories.ProductRepositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ValueTask<int> CreateAsync(ProductDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateAsync(int Id, ProductDto model)
        {
            throw new NotImplementedException();
        }
    }
}
