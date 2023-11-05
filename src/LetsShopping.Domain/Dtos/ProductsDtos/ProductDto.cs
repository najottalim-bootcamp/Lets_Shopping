namespace LetsShopping.Domain.Dtos.ProductsDtos
{
    public class ProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }       
        public int CompanyId { get; set; }
        public int DiscountId { get; set; }
        public int CategoryId { get; set; }
        public int PriceId { get; set; }
        public int Count { get; set; }
        public string ImgPath { get; set; } 
    }
}
