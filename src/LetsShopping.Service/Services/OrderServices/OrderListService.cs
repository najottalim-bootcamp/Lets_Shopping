
using LetsShopping.Domain.Dtos.OrdersDtos;
using LetsShopping.Service.Interfaces.OrderInterface;


namespace LetsShopping.Service.Services.OrderServices


{
    public class OrderListService : IOrderListInterface
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
