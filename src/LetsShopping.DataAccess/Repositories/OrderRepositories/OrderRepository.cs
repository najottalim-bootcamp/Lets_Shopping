namespace LetsShopping.DataAccess.Repositories.OrderRepositories
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public async ValueTask<int> CreateAsync(OrderDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Insert into Order(UserId,Total,Price,status,CreatedAt) Values({model.UserId},{model.Total},{model.Price},{(int)Status.Created},Getdate())";
                int created = await _connection.ExecuteAsync(query);
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
                string query = $"Exec DeletedById \'Order\',{Id}";
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

        public async ValueTask<IList<Order>> GetAllAsync()
        {
            try
            {
                await _connection.OpenAsync();
                string query = "Exec GetAll 'Orders'";
                var getall = (await _connection.QueryAsync<Order>(query)).ToList();
                return getall;
            }
            catch
            {
                return new List<Order>();

            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<Order> GetByIdAsync(int Id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Exec GetById 'Orders',{Id}";
                var getbyId = await _connection.QueryFirstOrDefaultAsync<Order>(query);
                return getbyId;
            }
            catch
            {
                return new Order();                
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<int> UpdateAsync(int Id, OrderDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Update Address Set Country = \'{model.UserId}\',City = \'{model.Price}\',Status = {(int)Status.Updated},UpdatedAt = GetDate() Where Id = {Id}";
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
