namespace LetsShopping.Domain.Models.Products
{
    public class Product : BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int InventoryId { get; set; }
        public int DiscountId { get; set; }
        public DateTime DeletedAt { get; set; }




    }
}
