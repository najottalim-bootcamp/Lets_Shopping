namespace LetsShopping.Service.Services.Order
{
    public class OrderDetailsServices : IOrderDetailsService
    {
        public ValueTask<bool> CreateOrderDetailsAsync(OrderDetailsDto orderDetailsDto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> DeleteOrderDetailsByIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<OrderDetails>> GetAllOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<OrderDetails> GetOrderDetailsByIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> UpdateOrderDetailsAsync(int orderId, OrderDetailsDto orderDetailsDto)
        {
            throw new NotImplementedException();
        }
    }
}
