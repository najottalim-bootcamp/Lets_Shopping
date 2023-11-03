namespace LetsShopping.Service.Services.Products
{
    public class ProductCategoryService : IProductCategoryService
    {
        public ValueTask<int> CreateProductCategoryAsync(ProductCategoryDto productCategoryDto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteProductCategoryAsync(int producCategorytId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<Product>> GetAllProductCategory(string Tablename)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> GetByIdProductCategoryId(int productCategoryId, string Tablename)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateProductCategoryAsync(int producCategorytId, ProductCategoryDto productCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
