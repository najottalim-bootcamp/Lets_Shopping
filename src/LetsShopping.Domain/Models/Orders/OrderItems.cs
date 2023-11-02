namespace LetsShopping.Domain.Models.Orders;

public class OrderItems : BaseClass
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}
