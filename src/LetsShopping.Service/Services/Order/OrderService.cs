namespace LetsShopping.Service.Services.Order
{
    public class OrderService : IOrderInterface
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderListRepository _orderListRepository;
        public OrderService(IOrderRepository orderRepository, IOrderListRepository orderListRepository)
        {
            _orderRepository = orderRepository;
            _orderListRepository = orderListRepository;

        }

        public async ValueTask<int> CreatedOrderList(OrderListDto orderListDto)
        {
            int orderList = await _orderListRepository.CreateAsync(orderListDto);
            if (orderList == null)
            {
                throw new OrderListNotFoundException();
            }
            return orderList;

        }

        public async ValueTask<int> CreateOrder(OrderDto orderDto)
        {
            var res = await _orderRepository.CreateAsync(orderDto);
            
            return res;
        }

        public ValueTask<int> DeleteOrder(int id)
        {
            var orderdelted = _orderListRepository.DeleteAsync(id);
            if (orderdelted == null)
            {
                throw new OrderNotFoundException();
            }
            return orderdelted;
        }

        public ValueTask<int> DeleteOrderList(int id)
        {
            var orderlistdeleted = _orderListRepository.DeleteAsync(id);
            if (orderlistdeleted == null)
            {
                throw new OrderListNotFoundException();
            }
            return orderlistdeleted;
        }

        public async ValueTask<List<Domain.Models.Orders.Order>> GetAllOrder()
        {
            List<Domain.Models.Orders.Order> orders = await _orderRepository.GetAllAsync();
            orders.Where(x => x.Status != Domain.Enums.Status.Deleted).ToList();
            if (orders == null)
            {
                throw new OrderNotFoundException();
            }
            return orders;
        }

        public async ValueTask<List<OrderList>> GetAllOrderList()
        {
            List<OrderList> ordersss = await _orderListRepository.GetAllAsync();
            ordersss.Where(x => x.Status != Domain.Enums.Status.Deleted).ToList();
            if (ordersss == null)
            {
                throw new OrderListNotFoundException();
            }
            return ordersss;
        }

        public async ValueTask<Domain.Models.Orders.Order> GetByIdOrder(int id)
        {
            Domain.Models.Orders.Order orders = await _orderRepository.GetByIdAsync(id);
            if (orders == null)
            {
                throw new OrderNotFoundException();
            }
            return orders;

        }

        public async ValueTask<OrderList> GetByIdOrderList(int id)
        {
            OrderList orderList = await _orderListRepository.GetByIdAsync(id);
            if (orderList == null)
            {
                throw new OrderListNotFoundException();
            }
            return orderList;

        }

        public async ValueTask<int> UpdateOrder(int id, OrderDto orderDto)
        {
            int updatedOrder = await _orderRepository.UpdateAsync(id, orderDto);
            return updatedOrder;
        }

        public async ValueTask<int> UpdateOrderList(int id, OrderListDto orderListDto)
        {
            int updateOrderList = await _orderListRepository.UpdateAsync(id, orderListDto);
            return updateOrderList;
        }
    }
}