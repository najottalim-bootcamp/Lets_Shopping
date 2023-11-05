namespace LetsShopping.Service.Dtos.DiscountDtos
{
    public class DiscountDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Percents { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
