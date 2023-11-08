namespace LetsShopping.Service.Interfaces.Order
{
    public interface IOrderInterface
    {
        // Order 
        public ValueTask<int> CreateOrder(OrderDto orderDto);
        public ValueTask<int> UpdateOrder(int id, OrderDto orderDto);
        public ValueTask<int> DeleteOrder(int id);
        public ValueTask<Domain.Models.Orders.Order> GetByIdOrder(int id);
        public ValueTask<List<Domain.Models.Orders.Order>> GetAllOrder();

        // OrderList

        public ValueTask<int> CreatedOrderList(OrderListDto orderListDto);
        public ValueTask<int> UpdateOrderList(int id, OrderListDto orderListDto);
        public ValueTask<int> DeleteOrderList(int id);
        public ValueTask<Domain.Models.Orders.OrderList> GetByIdOrderList(int id);
        public ValueTask<List<Domain.Models.Orders.OrderList>> GetAllOrderList();

    }
}
