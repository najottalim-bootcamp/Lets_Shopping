namespace LetsShopping.Domain.Exceptions.Prices
{
    public class PriceNotFoundException : NotFoundException
    {
        public PriceNotFoundException()
        {
            this.TitleMessage = "Price not Found";
        }
    }
}
