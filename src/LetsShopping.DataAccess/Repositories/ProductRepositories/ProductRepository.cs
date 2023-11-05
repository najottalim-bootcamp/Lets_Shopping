using Dapper;
using LetsShopping.Domain.Enums;
using LetsShopping.Domain.Models.Products;
using LetsShopping.Service.Dtos.ProductsDtos;
using System.Data;

namespace LetsShopping.DataAccess.Repositories.ProductRepositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public async ValueTask<int> CreateAsync(ProductDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Insert into Product(Name,Description,CompanyId,DiscountId,CategoryId,PriceId,Count,ImgPath,Status,CreatedAt) Values({model.Name},{model.Description},{model.CategoryId},{model.DiscountId},{model.CategoryId}, {model.PriceId},{model.Count},{model.ImgPath},{(int)Status.Created},Getdate());";
                int created = await _connection.ExecuteAsync(query, model);
                return created;
            }
            catch
            {
                return 0;
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<int> DeleteAsync(int Id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"EXEC DeleteById \'Product\' , {Id}";
                int deleted = await _connection.ExecuteAsync(query);
                return deleted;

            }
            catch
            {
                return 0;
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<IList<Product>> GetAllAsync()
        {
            try
            {
                await _connection.OpenAsync();
                string query = "Exec GetAll 'Product'";
                var get = (await _connection.QueryAsync<Product>(query)).ToList();
                return get;
            }
            catch
            {
                return new List<Product>();
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<Product> GetByIdAsync(int Id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"EXEC GetAllById 'Prices' , {Id};";
                var price = await _connection.QueryFirstOrDefaultAsync<Product>(query);
                return price;
            }
            catch
            {
                return new Product();

            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<int> UpdateAsync(int Id, ProductDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Update Product Set Product = {model.Name},{model.Description},{model.CompanyId},{model.DiscountId},{model.CategoryId},{model.PriceId},{model.Count},{model.ImgPath}, Status = {(int)Status.Updated},UpdatedAt = GetDate() Where Id = {Id}";
                int updated = await _connection.ExecuteAsync(query);
                return updated;

            }
            catch
            {
                return 0;
            }
            finally
            {
                await _connection.CloseAsync();
            }
            
        }
    }
}
