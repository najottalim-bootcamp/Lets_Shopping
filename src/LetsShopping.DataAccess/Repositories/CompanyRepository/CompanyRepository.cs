namespace LetsShopping.DataAccess.Repositories.CompanyRepository
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        public async ValueTask<int> CreateAsync(CompanyDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Insert into Company(Name,Description, PhoneNumber," +
                    $"AddressId,CardId ,Status , CreatedAt) Values" +
                    $"(\'{model.Name}\' ,\'{model.Description}\' , \'{model.PhoneNumber}\' " +
                    $", {model.AddressId},{model.СardId} ,{(int)Status.Created}, Getdate());";
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
                string query = $"EXEC DeleteById \'Company\' , {Id};";
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

        public async ValueTask<List<Company>> GetAllAsync()
        {
            try
            {
                await _connection.OpenAsync();
                string query = "Exec GetAll \'Company\'";
                var get = (await _connection.QueryAsync<Company>(query)).ToList();
                return get;
            }
            catch
            {
                return new List<Company>();
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<Company> GetByIdAsync(int Id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"EXEC GetAById \'Company\', {Id}";
                var company = await _connection.QueryFirstOrDefaultAsync<Company>(query);
                return company;
            }
            catch
            {
                return new Company();

            }
            finally
            {
                await _connection.CloseAsync();
            }

        }

        public async ValueTask<int> UpdateAsync(int Id, CompanyDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Update Company Set Name = \'{model.Name}\',Description = \'{model.Description}\' , " +
                    $"PhoneNumber =\'{model.PhoneNumber}\' , AddressId = {model.AddressId} , CardId = {model.СardId} , Status = {(int)Status.Updated},UpdatedAt = GetDate() Where Id = {Id}";
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
