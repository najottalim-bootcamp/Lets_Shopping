using LetsShopping.Domain.Models.Orders;
using LetsShopping.Service.Dtos.OrdersDtos;

namespace LetsShopping.Service.Interfaces.Orders
{
    public interface IOrderItemsService
    {
        //Create
        Task<bool> CreateOrderDetailsAsync(OrderItemsDto orderItemsDto);
        //Delete
        Task<bool> DeleteOrderDetailsByIdAsync(int orderItemId);
        //Get
        Task<IEnumerable<OrderDetails>> GetAllOrdersAsync(string tableName);
        //GetById
        Task<OrderDetails> GetOrderDetailsByIdAsync(int orderItemId);
        //Update
        Task<bool> UpdateOrderDetailsAsync(int orderItemId, OrderItemsDto orderDetailsDto);
    }
}
