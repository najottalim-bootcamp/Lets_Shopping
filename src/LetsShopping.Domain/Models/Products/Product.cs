namespace LetsShopping.Domain.Models.Products
{
    public class Product : BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CpmpanyId { get; set; }
        public int DiscountId { get; set; }
        public int CategoryId { get; set; }
        public int PriceId { get; set; }
        public int Count {get; set; }
        public string ImgPath { get; set; }

    }
}
