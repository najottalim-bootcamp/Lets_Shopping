namespace LetsShopping.DataAccess.Repositories.OrderRepositories
{
    public class OrderListRepository : BaseRepository, IOrderListRepository
    {
        public ValueTask<int> CreateAsync(OrderListDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<OrderList>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<OrderList> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateAsync(int Id, OrderListDto model)
        {
            throw new NotImplementedException();
        }
    }
}
