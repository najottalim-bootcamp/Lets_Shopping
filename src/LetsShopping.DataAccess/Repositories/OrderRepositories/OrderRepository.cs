namespace LetsShopping.DataAccess.Repositories.OrderRepositories
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public ValueTask<int> CreateAsync(OrderDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Order> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateAsync(int Id, OrderDto model)
        {
            throw new NotImplementedException();
        }
    }
}
