namespace LetsShopping.Service.Interfaces.Orders
{
    public interface IOrderDetailsService
    {
        public ValueTask<bool> CreateOrderDetailsAsync(OrderDetailsDto orderDetailsDto);
        public ValueTask<bool> DeleteOrderDetailsByIdAsync(int orderId);
        public ValueTask<List<Order>> GetAllOrdersAsync();
        public ValueTask<Order> GetOrderDetailsByIdAsync(int orderId);
        public ValueTask<bool> UpdateOrderDetailsAsync(int orderId, OrderDetailsDto orderDetailsDto);
    }
}
