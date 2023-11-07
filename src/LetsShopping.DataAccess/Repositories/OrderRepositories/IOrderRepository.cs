using LetsShopping.Domain.Dtos.OrdersDtos;

namespace LetsShopping.DataAccess.Repositories.OrderRepositories
{
    public interface IOrderRepository : IBaseRepository<Order, OrderDto>
    {
    }
}
