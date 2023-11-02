namespace LetsShopping.Domain.Models.Products
{
    public class ProductInvertory : BaseClass
    {
        public decimal Quantity { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
