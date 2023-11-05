using LetsShopping.Domain.Enums;

namespace LetsShopping.DataAccess.Repositories.AddressRepositories
{
    public class AddressRepository : BaseRepository, IAddressRepository
    {
        public async ValueTask<int> CreateAsync(AddressDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Insert into Address(Country,City,Status,CreatedAt) Values({model.Country} ,{model.City} ,{(int)Status.Created}, Getdate());";
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
                string query = $"EXEC DeleteById \'Address\' , {Id};";
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

        public async ValueTask<IList<Address>> GetAllAsync()
        {
            try
            {
                await _connection.OpenAsync();
                string query = "Exec GetAll 'Address'";
                var get = (await _connection.QueryAsync<Address>(query)).ToList();
                return get;
            }
            catch
            {
                return new List<Address>();
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<Address> GetByIdAsync(int Id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"EXEC GetAllById \'Addess\', {Id}";
                var address = await _connection.QueryFirstOrDefaultAsync<Address>(query);
                return address;
            }
            catch
            {
                return new Address();

            }
            finally
            {
                await _connection.CloseAsync();
            }

        }

        public async ValueTask<int> UpdateAsync(int Id, AddressDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Update Address Set Country = \'{model.Country}\',City = \'{model.City}\' ,Status = {(int)Status.Updated},UpdatedAt = GetDate() Where Id = {Id}";
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
