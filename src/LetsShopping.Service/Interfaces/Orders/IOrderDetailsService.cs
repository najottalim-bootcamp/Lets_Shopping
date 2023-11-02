using LetsShopping.Domain.Models.Orders;
using LetsShopping.Service.Dtos.OrdersDtos;

namespace LetsShopping.Service.Interfaces.Orders
{
    public interface IOrderDetailsService
    {
        //Create
        Task<bool> CreateOrderDetailsAsync(OrderDetailsDto orderDetailsDto);
        //Delete
        Task<bool> DeleteOrderDetailsByIdAsync(int orderId);
        //Get
        Task<IEnumerable<OrderDetails>> GetAllOrdersAsync();
        //GetById
        Task<OrderDetails> GetOrderDetailsByIdAsync(int orderId);
        //Update
        Task<bool> UpdateOrderDetailsAsync(int orderId,OrderDetailsDto orderDetailsDto);
    }
}
