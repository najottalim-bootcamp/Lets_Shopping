namespace LetsShopping.Service.Interfaces.Orders
{
    public interface IOrderItemsService
    {
        public ValueTask<bool> CreateOrderDetailsAsync(OrderItemsDto orderItemsDto);
        public ValueTask<bool> DeleteOrderDetailsByIdAsync(int orderItemId);
        public ValueTask<List<OrderList>> GetAllOrdersAsync();
        public ValueTask<OrderList> GetOrderDetailsByIdAsync(int orderItemId);
        public ValueTask<bool> UpdateOrderDetailsAsync(int orderItemId, OrderItemsDto orderDetailsDto);
    }
}
