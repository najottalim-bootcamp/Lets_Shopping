namespace LetsShopping.Service.Interfaces.Products
{
    public interface IProductService
    {
        public ValueTask<int> CreateProduct(ProductDto product);
        public ValueTask<int> UpdateProduct(int id,ProductDto product);
        public ValueTask<int> DeleteProduct(int id);
        public ValueTask<List<Product>> GetAllProduct(string Tablename);
        public ValueTask<Product> GetByIdProduct(int id,string Tablename);
    }
}
