namespace LetsShopping.Domain.Dtos.DiscountDtos
{
    public class DiscountDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Percents { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
