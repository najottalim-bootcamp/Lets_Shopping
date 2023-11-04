namespace LetsShopping.Domain.Models.Orders
{
    public class Order : BaseClass
    {
        public int UserId { get; set; }
        public DateTime DeletedAt { get; set; }

    }
}
