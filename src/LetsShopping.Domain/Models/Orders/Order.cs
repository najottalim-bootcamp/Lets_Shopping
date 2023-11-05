namespace LetsShopping.Domain.Models.Orders;

public class Order : BaseClass
{
    public int UserId { get; set; }
    public decimal Total { get; set; }
}
