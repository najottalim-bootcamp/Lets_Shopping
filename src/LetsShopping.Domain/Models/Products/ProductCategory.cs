namespace LetsShopping.Domain.Models.Products
{
    public class ProductCategory : BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
