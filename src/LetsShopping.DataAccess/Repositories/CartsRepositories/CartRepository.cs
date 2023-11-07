namespace LetsShopping.DataAccess.Repositories.CartsRepositories;

public class CartRepository : BaseRepository, ICartRepository
{
    public async ValueTask<int> CreateAsync(CartDto model)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"Insert into Cart(Active,Status,CreatedAt) Values('{model.Active}',{(int)Status.Created},Getdate());";
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
            string query = $"Exec Delete 'Cart',{Id}";
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

    public async ValueTask<IList<Cart>> GetAllAsync()
    {
        try
        {
            await _connection.OpenAsync();
            string query = "Exec GetAll 'Cart'";
            IList<Cart> get = (await _connection.QueryAsync<Cart>(query)).ToList();
            return get;
        }
        catch
        {
            return new List<Cart>();
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async ValueTask<Cart> GetByIdAsync(int Id)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"EXEC GetAllById 'Cart' , {Id};";
            Cart cart = await _connection.QueryFirstOrDefaultAsync<Cart>(query);
            return cart;
        }
        catch
        {
            return new Cart();

        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async ValueTask<int> UpdateAsync(int Id, CartDto model)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"Update Cart Set Active = '{model.Active}',Status = {(int)Status.Updated},UpdatedAt = GetDate() Where Id = {Id};";
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
