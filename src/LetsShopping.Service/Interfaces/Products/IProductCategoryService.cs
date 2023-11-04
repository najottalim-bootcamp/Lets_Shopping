namespace LetsShopping.Service.Interfaces.Products
{
    public interface IProductCategoryService
    {   
        public ValueTask<int> CreateProductCategoryAsync(ProductCategoryDto productCategoryDto);
        public ValueTask<int> UpdateProductCategoryAsync(int producCategorytId, ProductCategoryDto productCategoryDto);
        public ValueTask<int> DeleteProductCategoryAsync(int producCategorytId);
        public ValueTask<Product> GetByIdProductCategoryId(int productCategoryId,string Tablename);
        public ValueTask<List<Product>> GetAllProductCategory(string Tablename);
    }
}
