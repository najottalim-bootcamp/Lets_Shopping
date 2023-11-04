namespace LetsShopping.Domain.Models.Carts;

public class Cart : BaseClass
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public bool Active { get; set; }
    public CartStatus Status { get; set; } = CartStatus.Created;
}
