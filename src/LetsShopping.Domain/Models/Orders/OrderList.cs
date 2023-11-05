namespace LetsShopping.Domain.Models.Orders;
public class OrderList : BaseClass
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public DateTime DeletedAt { get; set; }
}
