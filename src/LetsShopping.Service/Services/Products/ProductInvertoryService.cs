namespace LetsShopping.Service.Services.Products
{
    public class ProductInvertoryService : IProductInvertoryService
    {
        public ValueTask<int> CreateProductINvertoryAsync(ProductInventoryDto productInventoryDto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteProductInvertory(int id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<Product>> GetAllProductInvertoryAsync(string Tablename)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> GetByIdProductInvertoryAsync(int id, string Tablename)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateProductInvertoryAsync(int id, ProductInventoryDto productInventoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
