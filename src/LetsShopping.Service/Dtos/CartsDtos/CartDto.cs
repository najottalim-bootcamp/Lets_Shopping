namespace LetsShopping.Service.Dtos.CartsDtos;

public class CartDto
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public bool Active { get; set; }
}
