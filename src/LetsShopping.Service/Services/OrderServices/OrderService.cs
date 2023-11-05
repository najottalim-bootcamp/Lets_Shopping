using LetsShopping.DataAccess.Repositories;
using LetsShopping.DataAccess.Repositories.OrderRepositories;
using LetsShopping.Domain.Exceptions.Orders;
using LetsShopping.Service.Interfaces.OrderInterfaces;

namespace LetsShopping.Service.Services.OrderService
{
    public class OrderService : IOrderInterface
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async ValueTask<int> CreateAsync(OrderDto model)
        {

            int res = await _orderRepository.CreateAsync(model);
            if (res == 0)
            {
                throw new OrderNotFoundException();
            }
            return res;
        }

        public async ValueTask<int> DeleteAsync(int Id)
        {
            int res = await _orderRepository.DeleteAsync(Id);
            if (res == 0)
            {
                throw new OrderNotFoundException();
            }
            return res;

        }
        public async ValueTask<Domain.Models.Orders.Order> GetByIdAsync(int Id)
        {

            Domain.Models.Orders.Order order = await _orderRepository.GetByIdAsync(Id);
            if (order == null)
            {
                throw new OrderNotFoundException();
            }
            return order;

        }

        public async ValueTask<int> UpdateAsync(int Id, OrderDto model)
        {
            int update = await _orderRepository.UpdateAsync(Id, model);
            if (update == 0)
            {
                throw new OrderNotFoundException();
            }
            return update;
        }

        public async ValueTask<IList<Domain.Models.Orders.Order>> GetAllAsync()
        {
            IList<Domain.Models.Orders.Order> order = (await _orderRepository.GetAllAsync());
            if (order == null)
            {
                throw new OrderNotFoundException();
            }
            return order;
        }
    }
}
