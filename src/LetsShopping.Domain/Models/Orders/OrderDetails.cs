using LetsShopping.Domain.Enums;

namespace LetsShopping.Domain.Models.Orders;

public class OrderDetails : BaseClass
{
    public int UserId { get; set; }
    public int BranchAddressId { get; set; }
    public decimal Total { get; set; }
    public OrderStatus Status { get; set; }
}
