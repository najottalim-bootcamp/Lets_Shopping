using LetsShopping.Domain.Models.Users;

namespace LetsShopping.DataAccess.Repositories.UserRepository;

public class UserRepository : BaseRepository, IUserRepository
{
    public async ValueTask<int> CreateAsync(UsersDto model)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"Insert into Users(FirstName,LastName,PhoneNumber,CardId,Status,CreatedAt) Values('{model.FirstName}','{model.LastName}','{model.PhoneNumber}','{model.CardId}',{(int)Status.Created},Getdate());";
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
            string query = $"Exec DeleteById 'Users',{Id}";
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

    public async ValueTask<List<User>> GetAllAsync()
    {
        try
        {
            await _connection.OpenAsync();
            string query = "Exec GetAll 'Users'";
            List<User> get = (await _connection.QueryAsync<User>(query)).ToList();
            return get;
        }
        catch
        {
            return new List<User>();
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async ValueTask<User> GetByIdAsync(int Id)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"EXEC GetAById 'Users' , {Id};";
            User user = await _connection.QueryFirstOrDefaultAsync<User>(query);
            return user;
        }
        catch
        {
            return new User();

        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async ValueTask<int> UpdateAsync(int Id, UsersDto model)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"Update Users Set FirstName = '{model.FirstName}',LastName = '{model.LastName}',PhoneNumber = '{model.PhoneNumber}',cardId = {model.CardId},Status = {(int)Status.Updated},ModifiedAt = GetDate() Where Id = {Id};";
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
