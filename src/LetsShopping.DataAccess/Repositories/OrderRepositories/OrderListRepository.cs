namespace LetsShopping.DataAccess.Repositories.OrderRepositories
{
    public class OrderListRepository : BaseRepository, IOrderListRepository
    {
        public async ValueTask<int> CreateAsync(OrderListDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Insert into OrderList(OrderId,ProductId,Status,CreatedAt) values({model.OrderId},{model.ProductId},{(int)Status.Created},Getdate())";
                int order = await _connection.ExecuteAsync(query);
                return order;
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
                string query = $"Exec DeletedById 'OrderList',{Id}";
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

        public async ValueTask<List<OrderList>> GetAllAsync()
        {
            try
            {
                await _connection.OpenAsync();
                string query = "Exec DeletedById 'OrderList'";
                var getall = (await _connection.QueryAsync<OrderList>(query)).ToList();
                return getall;
            }
            catch
            {
                return new List<OrderList>();
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<OrderList> GetByIdAsync(int Id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Exec GetById 'OrderList',{Id}";
                var getbyId = await _connection.QueryFirstOrDefaultAsync<OrderList>(query);
                return getbyId;
            }
            catch
            {
                return new OrderList();
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<int> UpdateAsync(int Id, OrderListDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Update Address Set OrderId = \'{model.OrderId}\',ProductId = \'{model.ProductId}\',Status = {(int)Status.Updated},UpdatedAt = GetDate() Where Id = {Id}";
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
