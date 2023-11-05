
using LetsShopping.Domain.Dtos.ProductsDtos;

namespace LetsShopping.Service.Services.Products
{
    public class ProductService : IProductService
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
