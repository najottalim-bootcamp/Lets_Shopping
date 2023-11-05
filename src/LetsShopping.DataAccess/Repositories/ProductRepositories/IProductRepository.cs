using LetsShopping.Domain.Dtos.ProductsDtos;

namespace LetsShopping.DataAccess.Repositories.ProductRepositories
{
    public interface IProductRepository : IBaseRepository<Product, ProductDto>
    {
    }
}
