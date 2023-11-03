using LetsShopping.Domain.Models.Orders;
using LetsShopping.Service.Dtos.OrdersDtos;

namespace LetsShopping.Service.Interfaces.Orders
{
    public interface IOrderDetailsService
    {
        public ValueTask<bool> CreateOrderDetailsAsync(OrderDetailsDto orderDetailsDto);
        public ValueTask<bool> DeleteOrderDetailsByIdAsync(int orderId);
        public ValueTask<List<OrderDetails>> GetAllOrdersAsync();
        public ValueTask<OrderDetails> GetOrderDetailsByIdAsync(int orderId);
        public ValueTask<bool> UpdateOrderDetailsAsync(int orderId,OrderDetailsDto orderDetailsDto);
    }
}
