using Dapper;
using LetsShopping.Domain.Enums;
using LetsShopping.Domain.Models.Users;
using LetsShopping.Domain.Dtos.UsersDtos;

namespace LetsShopping.DataAccess.Repositories.UserRepository;

public class UserRepository : BaseRepository, IUserRepository
{
    public async ValueTask<int> CreateAsync(UsersDto model)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"Insert into Users(FirstName,LastName,PhoneNumber,Password,Status,CreatedAt) Values('{model.FirstName}','{model.LastName}','{model.PhoneNumber}','{model.Password}',{(int)Status.Created},Getdate());";
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
            string query = $"Exec Delete 'Users',{Id}";
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

    public async ValueTask<IList<User>> GetAllAsync()
    {
        try
        {
            await _connection.OpenAsync();
            string query = "Exec GetAll 'Users'";
            IList<User> get = (await _connection.QueryAsync<User>(query)).ToList();
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
            string query = $"EXEC GetAllById 'Users' , {Id};";
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
            string query = $"Update Users Set FirstName = '{model.FirstName}',LastName = '{model.LastName}',PhoneNumber = '{model.PhoneNumber}',Password = '{model.Password}',Status = {(int)Status.Updated},UpdatedAt = GetDate() Where Id = {Id};";
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
