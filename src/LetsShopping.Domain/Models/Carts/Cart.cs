namespace LetsShopping.Domain.Models.Carts;

public class Cart : BaseClass
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public bool Active { get; set; }
    public DateTime DeletedAt { get; set; }
}
