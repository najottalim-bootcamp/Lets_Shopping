using LetsShopping.Domain.Enums;

namespace LetsShopping.DataAccess.Repositories.PriceRepositories
{
    public class PriceRepository : BaseRepository, IPriceRepository
    {
        public async ValueTask<int> CreateAsync(PriceDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Insert into Price(price,CreatedAt) Values({model.Price},Getdate());";
                int created = await _connection.ExecuteAsync(query, model);
                return created;
            }catch
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
                string query = $"Delete from Price Where Id = {Id}";
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

        public async ValueTask<IList<Price>> GetAllAsync()
        {
            try
            {
                await _connection.OpenAsync();
                string query = "Exec GetAll 'Prices'";
                var get = (await _connection.QueryAsync<Price>(query)).ToList();
                return get;                
            }
            catch
            {
                return new List<Price>();
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<Price> GetByIdAsync(int Id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Select * from where Id = {Id}";
                var price = await _connection.QueryFirstOrDefaultAsync<Price>(query);
                return price;
            }
            catch
            {
                return new Price();

            }
            finally
            {
                await _connection.CloseAsync();
            }
            
        }

        public async ValueTask<int> UpdateAsync(int Id, PriceDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Update Price Set Price = {model.Price},Status = {(int)Status.Updated},UpdatedAt = GetDate() Where Id = {Id}";
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
