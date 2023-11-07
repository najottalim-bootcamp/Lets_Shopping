using LetsShopping.DataAccess.Repositories.Discount;
using LetsShopping.Domain.Dtos.DiscountDtos;

namespace LetsShopping.DataAccess.Repositories.Discounts
{
    public class DiscountRepository : BaseRepository, IDiscountRepository
    {

        public async ValueTask<int> CreateAsync(DiscountDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Insert into Discount(Name,Description,Percents,StartDate,EndDate,Status,CreatedAt) Values" +
                    $"(\'{model.Name}\' ,\'{model.Description}\', {model.Percents} , {model.StartDate} " +
                    $",{model.EndDate} ,{(int)Status.Created}, Getdate());";
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
                string query = $"EXEC DeleteById \'Discount\' , {Id};";
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

        public async ValueTask<List<Domain.Models.Discount.Discount>> GetAllAsync()
        {
            try
            {
                await _connection.OpenAsync();
                string query = "Exec GetAll \'Discount\'";
                var get = (await _connection.QueryAsync<Domain.Models.Discount.Discount>(query)).ToList();
                return get;
            }
            catch
            {
                return new List<Domain.Models.Discount.Discount>();
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<Domain.Models.Discount.Discount> GetByIdAsync(int Id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"EXEC GetAllById \'Discount\', {Id}";
                var discount = await _connection.QueryFirstOrDefaultAsync<Domain.Models.Discount.Discount>(query);
                return discount;
            }
            catch
            {
                return new Domain.Models.Discount.Discount();

            }
            finally
            {
                await _connection.CloseAsync();
            }

        }

        public async ValueTask<int> UpdateAsync(int Id, DiscountDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Update Discount Set Name = \'{model.Name}\',Description = \'{model.Description}\' , " +
                    $"Percents = {model.Percents} , StartDate = {model.StartDate} , EndDate = {model.EndDate}," +
                    $"Status = {(int)Status.Updated},UpdatedAt = GetDate() Where Id = {Id}";
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
