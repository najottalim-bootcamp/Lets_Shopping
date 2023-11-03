namespace LetsShopping.Service.Services.Products
{
    public class ProductService : IProductService
    {
        public ValueTask<int> CreateProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<Product>> GetAllProduct(string Tablename)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> GetByIdProduct(int id, string Tablename)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateProduct(int id, ProductDto product)
        {
            throw new NotImplementedException();
        }
    }
}
