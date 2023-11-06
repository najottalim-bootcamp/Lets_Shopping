using LetsShopping.Service.Dtos.OrdersDtos;

namespace LetsShopping.DataAccess.Repositories.OrderRepositories
{
    public interface IOrderRepository : IBaseRepository<Order,OrderDto>
    {
    }
}
