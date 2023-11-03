namespace LetsShopping.Service.Interfaces.Products
{
    public interface IProductInvertoryService
    {
        public ValueTask<int> CreateProductINvertoryAsync(ProductInventoryDto productInventoryDto);
        public ValueTask<List<Product>> GetAllProductInvertoryAsync(string Tablename);
        public ValueTask<Product> GetByIdProductInvertoryAsync(int id, string Tablename);
        public ValueTask<int> UpdateProductInvertoryAsync(int id, ProductInventoryDto productInventoryDto);
        public ValueTask<int> DeleteProductInvertory(int id);
    }
}
